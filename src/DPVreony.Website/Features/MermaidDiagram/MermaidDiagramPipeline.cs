using Statiq.Common;
using Statiq.Core;

namespace DPVreony.Website.Features.MermaidDiagram
{
    public sealed class MermaidDiagramPipeline : Pipeline
    {
        public MermaidDiagramPipeline()
        {
            // we need to check for mermaidjs-cli
            // we need to look for *.mmd files
            this.InputModules = new ModuleList(new ReadFiles("./**/*.mmd"));

            this.ProcessModules = new ModuleList(new MermaidDiagramModule());
        }
    }
}
