using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Statiq.Common;

namespace DPVreony.Website.Features.MermaidDiagram
{
    public class ShellExecuteModule : Module
    {
        /// <inheritdoc />
        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync(IDocument input, IExecutionContext context)
        {
            var command = "node_modules\\.bin\\mmdc";
            var inputFilename = input.Source.FullPath;
            var outputFilename = input.Source.FileNameWithoutExtension.FullPath;
            var args = $"-i \"{inputFilename}\" -o \"{outputFilename}\"";
            var startInfo = new ProcessStartInfo(command, args);
            var process = Process.Start(startInfo);
            process.WaitForExit();

            return Array.Empty<IDocument>();
        }
    }
}
