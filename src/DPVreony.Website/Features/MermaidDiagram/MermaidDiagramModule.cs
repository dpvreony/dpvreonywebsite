
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
            context.LogInformation(input, "Starting ShellExecute Module");

            var inputFilename = Path.GetFullPath(input.Source.FullPath);

            var rootPath = Path.GetFullPath(context.FileSystem.RootPath.FullPath);

            var destination = input.Destination.FullPath;
            //var destinationAsPath = Path.GetPathRoot(destination);


            var outputFilename = Path.Combine(
                rootPath,
                "output",
                destination);

            outputFilename = Path.GetFullPath(outputFilename);

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

            return Array.Empty<IDocument>();
        }
    }
}
