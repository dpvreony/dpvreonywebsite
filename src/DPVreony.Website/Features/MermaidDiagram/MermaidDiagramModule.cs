
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Statiq.Common;

namespace DPVreony.Website.Features.MermaidDiagram
{
    public sealed class MermaidDiagramModule : Module
    {
        /// <inheritdoc />
        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync(IDocument input, IExecutionContext context)
        {
            context.LogInformation(input, "Starting Mermaid Diagram CLI Module");

            var inputFilename = Path.GetFullPath(input.Source.FullPath);

            var rootPath = Path.GetFullPath(context.FileSystem.RootPath.FullPath);

            var destination = input.Destination.FullPath;

            // this is taking the input folder, the output folder
            var outputFilename = Path.Combine(
                rootPath,
                "output",
                destination);
                
            // and reversing the path separator on the output
            outputFilename = Path.GetFullPath(outputFilename);

            // finally replace the file extension
            // could be a setting for now assume svg
            // might be a better way of doing all the output steps
            // within the Statiq Context would need to dig.
            outputFilename = Path.ChangeExtension(
                outputFilename,
                ".svg");

            var targetDir = Path.GetDirectoryName(outputFilename);

            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            var command = Path.Combine(
                rootPath,
                "node_modules\\.bin\\mmdc.cmd");

            var args = $"-i \"{inputFilename}\" -o \"{outputFilename}\"";

            context.LogInformation(input, $"Input Filename: {inputFilename}");
            context.LogInformation(input, $"Output Filename: {outputFilename}");
            context.LogInformation(input, $"Command: {command}");
            context.LogInformation(input, $"Args: {args}");

            if (!File.Exists(command))
            {
                throw new FileNotFoundException(".mmd files require NPM and mermaid-cli", command);
            }

            var startInfo = new ProcessStartInfo(command, args);
            startInfo.WorkingDirectory = rootPath;

            var process = Process.Start(startInfo);
            process.WaitForExit();

            var exitCode = process.ExitCode;
            if (exitCode != 0)
            {
                throw new InvalidOperationException($"Process exit code is: {exitCode}");
            }

            // CLI does all the output, we don't return anything ourself
            // could use console in \ out piping of CLI in future.
            // but could replace the NodeJS dependency with an inhouse generator
            // this is quick and leaves us without having to manage a mermaid dependency
            // (unless the CLI breaks)
            return Array.Empty<IDocument>();
        }
    }
}
