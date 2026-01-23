using System;
using Microsoft.Extensions.DependencyInjection;
using MyLittleContentEngine;
using MyLittleContentEngine.Models;
using MyLittleContentEngine.Services.Content;

namespace DPVreony.Website.Features.Mermaid
{
    public static class MermaidDiagramContentServiceExtensions
    {
        public static IConfiguredContentEngineServiceCollection AddMermaidDiagramContentService(
            this IConfiguredContentEngineServiceCollection services,
            Func<MermaidDiagramConversionContentOptions> optionsFunc)
        {
            var options = optionsFunc();

            services.AddSingleton(options);
            services.AddFileWatched<IMermaidDiagramConversionService, MermaidDiagramConversionService>();
            services.AddTransient<IContentService>(provider => provider.GetRequiredService<IMermaidDiagramConversionService>());

            return services;
        }
    }
}
