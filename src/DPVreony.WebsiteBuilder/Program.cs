using System.Threading.Tasks;
using AspNetStatic;
using AspNetStaticContrib.AspNetStatic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DPVreony.WebsiteBuilder
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSingleton<IStaticResourcesInfoProvider>(
                new StaticResourcesInfoProvider()
                    .AddAllProjectRazorPages(builder.Environment)
                    .AddAllWebRootContent(builder.Environment));

            // TODO: add index page
            // TODO: add the .mmd file conversion

            var app = builder.Build();
            app.MapRazorPages();
#if TBC
            app.GenerateStaticContent("../../../../DPVreony.Website/wwwroot");
#endif
            await app.RunAsync()
                .ConfigureAwait(false);

            return 0;
        }
    }
}
