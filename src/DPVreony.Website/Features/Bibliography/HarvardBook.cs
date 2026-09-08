using System.Collections.Generic;

namespace DPVreony.Website.Features.Bibliography
{
    public sealed record HarvardBook(
        string Id,
        string Title,
        IReadOnlyList<HarvardAuthorModel> Authors,
        int Year,
        string Publisher)
        : AbstractHarvardReferenceModel(Id, Title);
}
