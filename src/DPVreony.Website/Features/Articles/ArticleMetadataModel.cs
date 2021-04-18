using System;

namespace DPVreony.Website.Features.Articles
{
    public sealed class ArticleMetadataModel
    {
        public ArticleMetadataModel(
            ArticleStatus status,
            Version version,
            NodaTime.LocalDate firstRevision,
            NodaTime.LocalDate lastRevision,
            NodaTime.LocalDate lastReview,
            NodaTime.LocalDate nextReview)
        {
            Status = status;
            Version = version;
            FirstRevision = firstRevision;
            LastRevision = lastRevision;
            LastReview = lastReview;
            NextReview = nextReview;
        }

        public ArticleStatus Status { get; }

        public Version Version { get; }

        public NodaTime.LocalDate FirstRevision { get; }

        public NodaTime.LocalDate LastRevision { get; }

        public NodaTime.LocalDate LastReview { get; }

        public NodaTime.LocalDate NextReview { get; }
    }
}
