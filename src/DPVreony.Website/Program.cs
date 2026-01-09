using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;
using Whipstaff.Playwright;

namespace DPVreony.Website
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            new Whipstaff.Playwright.InstallationHelper(PlaywrightBrowserType.Chromium).InstallPlaywright();

            return await Bootstrapper
                .Factory
                .CreateWeb(args)
                .AddPipeline<Whipstaff.Statiq.Mermaid.MermaidDiagramPipeline>()
                .RunAsync();
        }
    }
}
