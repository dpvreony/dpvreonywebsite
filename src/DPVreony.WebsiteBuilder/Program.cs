// #define ENABLE_STATIC_PAGE_FALLBACK

using System;
using System.IO.Abstractions;
using System.Threading.Tasks;
using AspNetStatic;
using AspNetStaticContrib.AspNetStatic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Playwright;
using Whipstaff.Mermaid.Playwright;
using Whipstaff.Playwright;


namespace DPVreony.WebsiteBuilder
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;

            services.AddSingleton<IFileSystem>(new FileSystem());

            services.AddRouting(
                options =>
                {
                    options.LowercaseUrls = true;
                    options.LowercaseQueryStrings = true;
                    options.AppendTrailingSlash = false;
                });

            services.AddRazorPages();

            services.AddSingleton<IStaticResourcesInfoProvider>(
                GetStaticResourcesInfoProvider(builder)
                );

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


            // Use the "no-ssg" arg to omit static file generation
            // during development (hot-reload, etc.)
            var allowSSG = !args.HasOmitSsgArg();

            var exitWhenDone = args.HasExitWhenDoneArg();

            TimeSpan? regenInterval =
                !exitWhenDone &&
                TimeSpan.TryParse(builder.Configuration["AspNetStatic:RegenTimer"], out var ts)
                ? ts : null;

            #region app.UseStaticPageFallback()
#if ENABLE_STATIC_PAGE_FALLBACK

            if (allowSSG)
            {
                builder.Services.AddStaticPageFallback(
                    cfg =>
                    {
                        cfg.AlwaysDefaultFile = false;
                    });
            }

#endif
            #endregion


            var app = builder.Build();


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseHttpsRedirection();

            #region app.UseStaticPageFallback()
#if ENABLE_STATIC_PAGE_FALLBACK

            if (allowSSG)
            {
                app.UseStaticPageFallback();
            }

#endif
            #endregion

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();

            if (allowSSG)
            {
                app.GenerateStaticContent(
                    app.Environment.WebRootPath,
                    exitWhenDone: exitWhenDone,
                    alwaysDefaultFile: false,
                    dontUpdateLinks: false,
                    dontOptimizeContent: false,
                    regenerationInterval: regenInterval);
            }

            app.Use(async (context, next) =>
            {
                if (context.Request.Method == HttpMethods.Get && 
                    context.Request.Path.Value?.EndsWith(".svg", StringComparison.OrdinalIgnoreCase) == true)
                {
                    var path = context.Request.Path.Value.TrimStart('/');
                    var mmdPath = System.IO.Path.ChangeExtension(path, ".mmd");

                    var environment = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
                    var fileInfo = environment.WebRootFileProvider.GetFileInfo(mmdPath);

                    if (fileInfo.Exists)
                    {
                        var fileSystem = context.RequestServices.GetRequiredService<IFileSystem>();
                        var playwrightRendererBrowserInstance = context.RequestServices.GetRequiredService<IPlaywrightRendererBrowserInstance>();

                        var sourceFileInfo = fileSystem.FileInfo.New(mmdPath);
                        var mermaidDiagram = await playwrightRendererBrowserInstance.GetDiagramAsync(sourceFileInfo)
                            .ConfigureAwait(false);

                        if (mermaidDiagram != null)
                        {
                            var fileBytes = System.Text.Encoding.UTF8.GetBytes(mermaidDiagram.Svg);
                            context.Response.ContentType = "image/svg+xml";
                            await context.Response.Body.WriteAsync(fileBytes)
                                .ConfigureAwait(false);
                            return;
                        }
                    }
                }

                await next(context).ConfigureAwait(false);
            });

            await app.RunAsync()
                .ConfigureAwait(false);

            return 0;
        }

        private static StaticResourcesInfoProvider GetStaticResourcesInfoProvider(WebApplicationBuilder builder)
        {
            var environment = builder.Environment;

            return new StaticResourcesInfoProvider()
                .Add(StaticPagesFactory.GetCollection())
                .Add(environment.GetWebRootCssResources(
                    ["css/**/*.css"]))
                .Add(environment.GetWebRootCssResources(
                    ["lib/bootstrap/**/*.css"],
                    dontOptimize: true))
                .Add(environment.GetWebRootJsResources(
                    ["js/**/*.js"]))
                .Add(environment.GetWebRootJsResources(
                    ["lib/bootstrap/**/*.js",
                        "lib/bootstrap/**/*.js.map",
                        "lib/jquery*/**/*.js",
                        "lib/jquery*/**/*.map"],
                    dontOptimize: true))
                .Add(environment.GetWebRootBinResources(
                    ["favicon.ico"]))
                .Add(environment.GetWebRootBinResources(
                    ["lib/bootstrap/license",
                        "lib/jquery*/license.*"],
                    dontOptimize: true));
        }
    }
}
