using System;
using System.Collections.Generic;
using DPVreony.Website.Features.Bibliography;

namespace DPVreony.Website.Features.Articles
{
    public sealed record ArticleMetadataModel(
        ArticleStatus Status,
        Version Version,
        NodaTime.LocalDate FirstRevision,
        NodaTime.LocalDate LastRevision,
        NodaTime.LocalDate LastReview,
        NodaTime.LocalDate NextReview,
        IList<AbstractHarvardReferenceModel> References);
}
