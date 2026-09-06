using System.Collections.Generic;

namespace DPVreony.Website.Features.Bibliography
{
    public sealed record HarvardJournalArticle(
        string Id,
        string Title,
        IReadOnlyList<HarvardAuthorModel> Authors,
        int Year,
        string Journal)
        : AbstractHarvardReferenceModel(Id, Title);
}

