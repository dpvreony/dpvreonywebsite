using AspNetStatic;
using AspNetStaticContrib.AspNetStatic;
using Microsoft.AspNetCore.Hosting;

namespace DPVreony.WebsiteBuilder
{
    public static class StaticResourcesInfoProviderExtensions
    {
        public static StaticResourcesInfoProvider AddBootstrap(this StaticResourcesInfoProvider staticResourcesInfoProvider, IWebHostEnvironment environment)
        {
            return staticResourcesInfoProvider.Add(environment.GetWebRootCssResources(
                    ["lib/bootstrap/**/*.css"],
                    dontOptimize: true))
                .Add(environment.GetWebRootJsResources(
                    [
                        "lib/bootstrap/**/*.js",
                        "lib/bootstrap/**/*.js.map",
                        "lib/jquery*/**/*.js",
                        "lib/jquery*/**/*.map"
                    ],
                    dontOptimize: true));
        }

        public static StaticResourcesInfoProvider AddCookieConsent(
            this StaticResourcesInfoProvider staticResourcesInfoProvider,
            IWebHostEnvironment environment)
        {

        }

        public static StaticResourcesInfoProvider AddFontAwesomeFree(
            this StaticResourcesInfoProvider staticResourcesInfoProvider,
            IWebHostEnvironment environment)
        {
            return staticResourcesInfoProvider.Add(environment.GetWebRootBinResources(
                ["lib/fontawesome-free/webfonts/*.*"],
                dontOptimize: true));

        }

        public static StaticResourcesInfoProvider AddFonts(
            this StaticResourcesInfoProvider staticResourcesInfoProvider,
            IWebHostEnvironment environment)
        {
            return staticResourcesInfoProvider.Add(environment.GetWebRootBinResources(
                ["fonts/*.*"],
                dontOptimize: true));
        }

        public static StaticResourcesInfoProvider AddJQuery(
            this StaticResourcesInfoProvider staticResourcesInfoProvider,
            IWebHostEnvironment environment)
        {

        }
    }
}
