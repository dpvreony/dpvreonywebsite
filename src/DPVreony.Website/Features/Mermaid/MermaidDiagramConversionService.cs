using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO.Abstractions;
using System.Threading.Tasks;
using MyLittleContentEngine.Models;
using MyLittleContentEngine.Services.Content.TableOfContents;
using Whipstaff.Mermaid.Playwright;

namespace DPVreony.Website.Features.Mermaid
{
    public sealed class MermaidDiagramConversionService : IMermaidDiagramConversionService
    {
        private MermaidDiagramConversionContentOptions _options;
        private IFileSystem _fileSystem;

        public MermaidDiagramConversionService(
            MermaidDiagramConversionContentOptions options,
            IFileSystem fileSystem)
        {
            _options = options;
            _fileSystem = fileSystem;
        }

        public int SearchPriority => 5;

        public Task<ImmutableList<ContentTocItem>> GetContentTocEntriesAsync()
        {
            return Task.FromResult(ImmutableList<ContentTocItem>.Empty);
        }

        public Task<ImmutableList<ContentToCopy>> GetContentToCopyAsync()
        {
            return Task.FromResult(ImmutableList<ContentToCopy>.Empty);
        }

        public Task<ImmutableList<CrossReference>> GetCrossReferencesAsync()
        {
            return Task.FromResult(ImmutableList<CrossReference>.Empty);
        }

        public Task<ImmutableList<PageToGenerate>> GetPagesToGenerateAsync()
        {
            if (!_fileSystem.Directory.Exists(_options.Path))
            {
                return Task.FromResult(ImmutableList<PageToGenerate>.Empty);
            }

            var pages = new List<PageToGenerate>();
            var files = _fileSystem.Directory.EnumerateFiles(
                _options.Path,
                "*.mmd");

            foreach (var currentFile in files)
            {
                var filename = _fileSystem.Path.GetFileNameWithoutExtension(currentFile);

                var url = $"/images/{filename}.svg";
                var outputPath = $"images/{filename}.svg";

                pages.Add(new PageToGenerate(url, outputPath, new Metadata(), true));
            }

            return Task.FromResult(pages.ToImmutableList());
        }
    }
}
