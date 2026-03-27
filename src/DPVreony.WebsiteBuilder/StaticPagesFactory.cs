using System.Collections.Generic;
using AspNetStatic;
using AspNetStatic.Optimizer;

namespace DPVreony.WebsiteBuilder
{
    public class StaticPagesFactory
    {
        public static IEnumerable<PageResource> GetCollection() =>
        [
            new("/"),
            new("/opensource/"),
            new("/resume/"),
            new("/privacy/"),
            new("/articles/"),
            new("/articles/designing-vetuviem/"),
            new("/articles/designing-vetuviem/diagram-class-viewtoviewmodel-relationship.svg") { OptimizationType = OptimizationType.None},
            new("/articles/designing-vetuviem/diagram-controlbindingmodel-hierachy.svg") { OptimizationType = OptimizationType.None},
        ];
    }
}
