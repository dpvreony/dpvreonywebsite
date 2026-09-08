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
    }
}
