// #define ENABLE_STATIC_PAGE_FALLBACK

using System;
using System.Threading.Tasks;
using AspNetStatic;
using AspNetStaticContrib.AspNetStatic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DPVreony.WebsiteBuilder
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRouting(
                options =>
                {
                    options.LowercaseUrls = true;
                    options.LowercaseQueryStrings = true;
                    options.AppendTrailingSlash = false;
                });

            builder.Services.AddRazorPages();

            builder.Services.AddSingleton<IStaticResourcesInfoProvider>(
                GetStaticResourcesInfoProvider(builder)
                );

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
