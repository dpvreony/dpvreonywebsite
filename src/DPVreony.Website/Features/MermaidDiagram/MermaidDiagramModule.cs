
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Statiq.Common;
using Whipstaff.Mermaid.HttpServer;
using Whipstaff.Mermaid.Playwright;
using Whipstaff.Playwright;

namespace DPVreony.Website.Features.MermaidDiagram
{
    public sealed class MermaidDiagramModule : Module
    {
        private readonly System.IO.Abstractions.IFileSystem _fileSystem;

        public MermaidDiagramModule(System.IO.Abstractions.IFileSystem fileSystem)
        {
            ArgumentNullException.ThrowIfNull(fileSystem);
            _fileSystem = fileSystem;
        }

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

            var logMessageActions = new PlaywrightRendererLogMessageActions();
            var loggerFactory = context.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger<PlaywrightRenderer>();
            var logMessageActionsWrapper = new PlaywrightRendererLogMessageActionsWrapper(logMessageActions, logger);
            var mermaidHttpServer = MermaidHttpServerFactory.GetTestServer(loggerFactory);

            var playwrightRenderer = new Whipstaff.Mermaid.Playwright.PlaywrightRenderer(
                mermaidHttpServer,
                logMessageActionsWrapper);

            var markdown = await _fileSystem.File.ReadAllTextAsync(inputFilename);

            var diagramResponse = await playwrightRenderer.GetDiagram(
                markdown,
                PlaywrightBrowserTypeAndChannel.ChromiumDefault())
                .ConfigureAwait(false);

            if (diagramResponse == null)
            {
                throw new InvalidOperationException("Failed to generate diagram");
            }

            await _fileSystem.File.WriteAllTextAsync(
                outputFilename,
                diagramResponse.Svg)
                .ConfigureAwait(false);

            // keeping the working the same as the previous cli version
            // could return the response object in future.
            return Array.Empty<IDocument>();
        }
    }
}
