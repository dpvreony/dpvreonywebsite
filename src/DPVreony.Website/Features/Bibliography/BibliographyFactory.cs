using System;
using System.Collections.Generic;

namespace DPVreony.Website.Features.Bibliography
{
    public class BibliographyFactory
    {
        public static HarvardWebPage DocumentingArchitectureDecisions() => new HarvardWebPage(
            "1",
            "Documenting Architecture Decisions",
            new List<HarvardAuthorModel> { new("Nygard", "M") },
            new Uri("https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions"),
            new DateOnly(2026, 3, 27),
            2011,
            11,
            15);

        public static HarvardWebPage ArchitecturalDecisionGuidanceAcrossProjects() => new HarvardWebPage(
            "2",
            "Architectural Decision Guidance Across Projects",
            new List<HarvardAuthorModel> { new("Zimmermann", "O") },
            new Uri("https://www.ozimmer.ch/practices/2020/04/27/ArchitectureDecisionMaking.html"),
            new DateOnly(2026, 3, 27),
            2020,
            04,
            27);

        public static HarvardBook BusinessPolicyTextAndCases() => new HarvardBook(
            "3",
            "Business Policy: Text and Cases",
            new List<HarvardAuthorModel>
            {
                new ("Learned", "E"),
                new ("Christensen", "C"),
                new ("Andrews", "K"),
                new ("Guth", "W")
            },
            1965,
            "Homewood, IL: Irwin.");

        public static HarvardBook DesignItFromProgrammerToSoftwareArchitect() => new HarvardBook(
            "4",
            "Design It! From Programmer to Software Architect",
            [new("Keeling", "M")],
            2017,
            "Pragmatic Bookshelf");

        public static HarvardBook TheRiseAndFallOfStrategicPlanning() => new HarvardBook(
            "5",
            "The Rise and Fall of Strategic Planning",
            [new HarvardAuthorModel("Mintzberg", "H")],
            1994,
            "Harvard Business Review Press");

        public static HarvardBook SoftwareArchitectureTheHardParts() => new HarvardBook(
            "6",
            "Software Architecture: The Hard Parts",
            [
                new HarvardAuthorModel("Ford", "N"),
                new HarvardAuthorModel("Richards", "M"),
                new HarvardAuthorModel("Sadalage", "P"),
                new HarvardAuthorModel("Dehghani", "Z"),
            ],
            2021,
            "O'Reilly Media");

        public static HarvardBook TheBalancedScorecardTranslatingStrategyIntoAction() => new HarvardBook(
            "7",
            "The Balanced Scorecard: Translating Strategy into Action",
            [
                new HarvardAuthorModel("Kaplan", "R. S."),
                new HarvardAuthorModel("Norton", "D. P."),
            ],
            1996,
            "Harvard Business Review Press");

        public static AbstractHarvardReferenceModel MadrMarkdownArchitecturalDecisionRecords()
        {
            return new HarvardWebPage(
                "8",
                "MADR: Markdown Architectural Decision Records",
                new List<HarvardAuthorModel> { new("Nygard", "M") },
                new Uri("https://github.com/adr/madr"),
                new DateOnly(2026, 3, 27),
                2017,
                11,
                22);
        }

        public static AbstractHarvardReferenceModel ArchitectureDecisionMaking()
        {
            return new HarvardWebPage(
                "9",
                "Architecture Decision Making",
                new List<HarvardAuthorModel> { new("Zimmermann", "O") },
                new Uri("https://www.ozimmer.ch/practices/2020/04/27/ArchitectureDecisionMaking.html"),
                new DateOnly(2026, 3, 27),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel ArchitectureDecisionRecord()
        {
            return new HarvardWebPage(
                "10",
                "Architecture Decision Record",
                new List<HarvardAuthorModel> { new("Henderson", "J. P.") },
                new Uri("https://github.com/architecture-decision-record/architecture-decision-record"),
                new DateOnly(2026, 3, 27),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel ArchitectureDecisionRecordsGithubHomePage()
        {
            return new HarvardWebPage(
                "11",
                "Architecture Decision Records GitHub Home Page",
                new List<HarvardAuthorModel> { new("Kopp", "O.") },
                new Uri("https://adr.github.io/"),
                new DateOnly(2026, 3, 27),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel ReactiveUiRfcs23()
        {
            return new HarvardWebPage(
                "12",
                "ReactiveUI RFC: Application Performance Monitoring Integration",
                new List<HarvardAuthorModel> { new("Vreony", "D. P.") },
                new Uri("https://github.com/reactiveui/rfcs/issues/23"),
                new DateOnly(2021, 05, 31),
                2019,
                2,
                1);
        }

        public static AbstractHarvardReferenceModel SourceGeneratorsCookbook()
        {
            return new HarvardWebPage(
                "13",
                "Roslyn Source Generators Cookbook",
                new List<HarvardAuthorModel> { new("Microsoft", "Corp.") },
                new Uri("https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md"),
                new DateOnly(2021, 05, 31),
                2021,
                5,
                31);
        }

        public static AbstractHarvardReferenceModel WhipstaffPlaywrightWebCrawler()
        {
            return new HarvardWebPage(
                "14",
                "Whipstaff Playwright Web Crawler",
                new List<HarvardAuthorModel> { new("Vreony", "D. P.") },
                new Uri("https://github.com/dpvreony/whipstaff-playwright-web-crawler"),
                new DateOnly(2021, 05, 31),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel WhipstaffPlaywrightPageExtensions()
        {
            return new HarvardWebPage(
                "15",
                "Whipstaff Playwright Page Extensions",
                new List<HarvardAuthorModel> { new("Vreony", "D. P.") },
                new Uri("https://github.com/dpvreony/whipstaff-playwright-page-extensions"),
                new DateOnly(2021, 05, 31),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel WhipstaffPlaywrightPlaywrightRendererBrowserInstance()
        {
            return new HarvardWebPage(
                "16",
                "Whipstaff Playwright Playwright Renderer Browser Instance",
                new List<HarvardAuthorModel> { new("Vreony", "D. P.") },
                new Uri("https://github.com/dpvreony/whipstaff-playwright-playwright-renderer-browser-instance"),
                new DateOnly(2021, 05, 31),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel SolidlyStatedEdgeWindows10CantReachLocalhostSites()
        {
            return new HarvardWebPage(
                "17",
                "Solidly Stated Edge Windows 10 Can't Reach Localhost Sites",
                new List<HarvardAuthorModel> { new("Vreony", "D. P.") },
                new Uri("https://github.com/dpvreony/solidly-stated-edge-windows-10-cant-reach-localhost-sites"),
                new DateOnly(2021, 01, 20),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel GithubMermaidCli()
        {
            return new HarvardWebPage(
                "18",
                "GitHub Mermaid CLI",
                new List<HarvardAuthorModel> { new("Mermaid", "") },
                new Uri("https://github.com/mermaid-js/mermaid-cli"),
                new DateOnly(2021, 03, 27),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel MermaidFlowchartSample()
        {
            return new HarvardWebPage(
                "19",
                "Mermaid Flowchart Sample",
                new List<HarvardAuthorModel> { new("Mermaid", "") },
                new Uri("https://mermaid-js.github.io/mermaid/#/flowchart?id=flowcharts-basic-syntax"),
                new DateOnly(2021, 03, 27),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel MartinBjorkstromPortedBlogToStatiq()
        {
            return new HarvardWebPage(
                "20",
                "I ported my blog to Statiq",
                new List<HarvardAuthorModel> { new("Björkström", "M") },
                new Uri("https://martinbjorkstrom.com/posts/2020-04-20-i-ported-my-blog-to-statiq"),
                new DateOnly(2021, 03, 27),
                2020,
                4,
                20);
        }

        public static AbstractHarvardReferenceModel DontPutAndroidInYourNamespaceInXamarinProjects()
        {
            return new HarvardWebPage(
                "21",
                "Don't Put Android in Your Namespace in Xamarin Projects",
                new List<HarvardAuthorModel> { new("Montemagno", "James") },
                new Uri("https://montemagno.com/dont-put-android-in-your-namespace-in-xamarin-apps/"),
                new DateOnly(2020, 12, 01),
                2020,
                12,
                01);
        }

        public static AbstractHarvardReferenceModel OpenWrtWikiNetgearWNDR3800()
        {
            return new HarvardWebPage(
                "22",
                "OpenWrt Wiki: Netgear WNDR3800",
                new List<HarvardAuthorModel> { new("OpenWrt", "") },
                new Uri("https://openwrt.org/toh/netgear/wndr3800"),
                new DateOnly(2020, 08, 11),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel DrayTekSupportSkyFibreSetupGuide()
        {
            return new HarvardWebPage(
                "23",
                "DrayTek Support: Sky Fibre Setup Guide",
                new List<HarvardAuthorModel> { new("DrayTek", "") },
                new Uri("https://www.draytek.co.uk/support/guides/sky-fibre-setup-guide"),
                new DateOnly(2021, 05, 31),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel ThoughtWorksTechnologyRadarArchitectureDecisionRecords()
        {
            return new HarvardWebPage(
                "24",
                "ThoughtWorks Technology Radar: Architecture Decision Records",
                new List<HarvardAuthorModel> { new("ThoughtWorks", "") },
                new Uri("https://www.thoughtworks.com/radar/architecture-decision-records"),
                new DateOnly(2021, 05, 31),
                null,
                null,
                null);
        }

        public static AbstractHarvardReferenceModel TheTacitDimension()
        {
            return new HarvardBook(
                "25",
                "The Tacit Dimension",
                new List<HarvardAuthorModel> { new("Polanyi", "M") },
                1965,
                "University of Chicago Press");
        }

        public static AbstractHarvardReferenceModel TheKnowledgeCreatingCompany()
        {
            return new HarvardBook(
                "26",
                "The Knowledge-Creating Company: How Japanese Companies Create the Dynamics of Innovation",
                new List<HarvardAuthorModel> { new("Nonaka", "I"), new("Takeuchi", "H") },
                1995,
                "Oxford University Press");
        }

        public static AbstractHarvardReferenceModel CodeAsDocumentation()
        {
            return new HarvardWebPage(
                "27",
                "Code As Documentation",
                new List<HarvardAuthorModel> { new("Fowler", "M") },
                new Uri("https://martinfowler.com/bliki/CodeAsDocumentation.html"),
                new DateOnly(2021, 05, 31),
                2005,
                3,
                22);
        }
    }
}
