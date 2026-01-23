using System.IO.Abstractions;
using System.Threading.Tasks;
using DPVreony.Website.Components;
using DPVreony.Website.Features.Mermaid;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using MyLittleContentEngine;
using MyLittleContentEngine.MonorailCss;
using Whipstaff.Mermaid.HttpServer;
using Whipstaff.Mermaid.Playwright;
using Whipstaff.Playwright;

namespace DPVreony.Website
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            new Whipstaff.Playwright.InstallationHelper(PlaywrightBrowserType.Chromium).InstallPlaywright();


            var builder = WebApplication.CreateBuilder(args);

            var services = builder.Services;
            services.AddRazorComponents();

            // configures site wide settings
            // hot reload note - these will not be reflected until the application restarts
            services.AddContentEngineService(_ => new ContentEngineOptions
            {
                SiteTitle = "DPVreony",
                SiteDescription = "Website for DPVreony",
                ContentRootPath = "Content/_trunk",
            }).WithMarkdownContentService(_ => new MarkdownContentOptions<BlogFrontMatter>
            {
                ContentPath = "Content",
                BasePageUrl = string.Empty,
                ExcludeSubfolders = true
            });

            //.WithMarkdownContentService(_ => new MarkdownContentOptions<BlogFrontMatter>
            //{
            //    ContentPath = "Content/Articles",
            //    BasePageUrl = "/articles", 
            //});

            services.AddMonorailCss();
            services.AddKeyedSingleton<TestServer>(
                "mermaid",
                static (sp, _) =>
                {
                    var loggerFactory = sp.GetRequiredService<ILoggerFactory>();
                    var fileSystem = sp.GetRequiredService<IFileSystem>();
                    return MermaidHttpServerFactory.GetTestServer(
                        loggerFactory,
                        fileSystem);
                });
            services.AddSingleton<PlaywrightRenderer>(static provider =>
            {
                var mermaidHttpServer = provider.GetRequiredKeyedService<TestServer>("mermaid");
                var logMessageActions = new PlaywrightRendererBrowserInstanceLogMessageActions();
                var loggerFactory = provider.GetRequiredService<ILoggerFactory>();
                var logger = loggerFactory.CreateLogger<PlaywrightRendererBrowserInstance>();
                var logMessageActionsWrapper = new PlaywrightRendererBrowserInstanceLogMessageActionsWrapper(
                    logMessageActions,
                    logger);
                return new Whipstaff.Mermaid.Playwright.PlaywrightRenderer(
                    mermaidHttpServer,
                    logMessageActionsWrapper);
            });
            services.AddSingleton<IPlaywrightRendererBrowserInstance>(static provider =>
            {
                var playwrightRenderer = provider.GetRequiredService<PlaywrightRenderer>();
                return playwrightRenderer.GetBrowserSessionAsync(PlaywrightBrowserTypeAndChannel.ChromiumDefault()).GetAwaiter().GetResult();
            });

            var app = builder.Build();
            app.UseAntiforgery();
            app.MapStaticAssets();
            app.MapRazorComponents<App>();
            app.UseMonorailCss();

            app.MapGet("/*/{filename}.mmd",
                async (
                    string filename,
                    Whipstaff.Mermaid.Playwright.IPlaywrightRendererBrowserInstance playwrightRendererBrowserInstance,
                    IFileSystem fileSystem) =>
                {
                    var sourceFileInfo = fileSystem.FileInfo.New(filename);
                    var mermaidDiagram = await playwrightRendererBrowserInstance.GetDiagramAsync(sourceFileInfo)
                        .ConfigureAwait(false);

                    if (mermaidDiagram == null)
                    {
                        return Results.NotFound();
                    }

                    return Results.File(
                        mermaidDiagram.Svg,
                        "image/svg+xml");
                });

            await app.RunOrBuildContent(args);

            return 0;
        }
    }
}
