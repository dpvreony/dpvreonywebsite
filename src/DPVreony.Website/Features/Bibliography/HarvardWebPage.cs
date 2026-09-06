using System;
using System.Collections.Generic;

namespace DPVreony.Website.Features.Bibliography
{
    public sealed record HarvardWebPage(
        string Id,
        string Title,
        IReadOnlyList<HarvardAuthorModel> Authors,
        Uri Url,
        DateOnly Accessed,
        int? Year,
        int? Month,
        int? Day)
        : AbstractHarvardReferenceModel(Id, Title);
}
