using System.Collections.Generic;
using AspNetStatic;
using AspNetStatic.Optimizer;

namespace DPVreony.WebsiteBuilder
{
    public class StaticPagesFactory
    {
        public static IEnumerable<PageResource> GetCollection()
        {
            yield return new("/");
            yield return new("/opensource/");
            yield return new("/resume/");
            yield return new("/privacy/");
            yield return new("/articles/");
            yield return new("/articles/architecture-decision-records/");
            yield return new("/articles/configuring-android-with-exchange-alias/");
            yield return new("/articles/crawling-a-website-as-integration-test/");
            yield return new("/articles/designing-apm-splat/");
            yield return new("/articles/designing-nucleotide/");
            yield return new("/articles/designing-vetuviem/");
            yield return new("/articles/designing-whipstaff/");
            yield return new("/articles/docfx-as-a-downstream-repository/");
            yield return new("/articles/feature-usage-tracking/");
            yield return new("/articles/knowledge-management-timeline/");
            yield return new("/articles/mermaid-with-statiq/");
            yield return new("/articles/mitigate-registration-page-email-abuse/");
            yield return new("/articles/mitigating-j-curves/");
            yield return new("/articles/naming-convention-net-projects/");
            yield return new("/articles/opensource/");
            yield return new("/articles/running-a-software-developer-interview-process/");
            yield return new("/articles/sky-using-own-modem-and-router/");
            yield return new("/articles/sourcegenerator-using-json/");
            yield return new("/articles/using-technical-steering/");
        }

        public static IEnumerable<BinResource> GetBinResources() =>
        [
            new("/articles/designing-vetuviem/diagram-class-viewtoviewmodel-relationship.svg"),
            new("/articles/designing-vetuviem/diagram-controlbindingmodel-hierachy.svg"),
        ];
    }
}
