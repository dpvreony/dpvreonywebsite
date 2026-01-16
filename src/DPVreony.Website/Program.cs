using System.Threading.Tasks;
using DPVreony.Website.Components;
using MyLittleContentEngine;
using MyLittleContentEngine.MonorailCss;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Whipstaff.Playwright;

namespace DPVreony.Website
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            new Whipstaff.Playwright.InstallationHelper(PlaywrightBrowserType.Chromium).InstallPlaywright();


            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorComponents();

            // configures site wide settings
            // hot reload note - these will not be reflected until the application restarts
            builder.Services.AddContentEngineService(_ => new ContentEngineOptions
            {
                SiteTitle = "My Little Content Engine",
                SiteDescription = "An Inflexible Content Engine for .NET",
                ContentRootPath = "Content",
            }).WithMarkdownContentService(_ => new MarkdownContentOptions<BlogFrontMatter>
            {
                ContentPath = "Content",
                BasePageUrl = string.Empty
            });

            builder.Services.AddMonorailCss();

            var app = builder.Build();
            app.UseAntiforgery();
            app.MapStaticAssets();
            app.MapRazorComponents<App>();
            app.UseMonorailCss();

            await app.RunOrBuildContent(args);

            return 0;
        }
    }
}
