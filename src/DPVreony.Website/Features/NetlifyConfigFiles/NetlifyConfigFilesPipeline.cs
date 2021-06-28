using Statiq.Common;
using Statiq.Core;

namespace DPVreony.Website.Features.NetlifyConfigFiles
{
    public sealed class NetlifyConfigFilesPipeline : Pipeline
    {
        public NetlifyConfigFilesPipeline()
        {
            this.InputModules = new ModuleList(new ReadFiles("{_headers,netlify.toml,_redirects}"));
            this.OutputModules = new ModuleList(new WriteFiles());
        }
    }
}
