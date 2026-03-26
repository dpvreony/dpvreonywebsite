using System.Collections.Generic;
using AspNetStatic;

namespace DPVreony.WebsiteBuilder
{
    public class StaticPagesFactory
    {
        public static IEnumerable<PageResource> GetCollection() =>
        [
            new("/"),
            new("/opensource"),
            new("/resume"),
            new("/privacy"),
            new("/articles/"),
        ];
    }
}
