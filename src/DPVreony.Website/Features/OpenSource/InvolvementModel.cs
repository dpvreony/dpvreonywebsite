using System;

namespace DPVreony.Website.Features.OpenSource
{
    public sealed class InvolvementModel
    {
        public InvolvementModel(
            string title,
            string description,
            Uri? githubUri,
            ArticleModel[]? articles)
        {
            Title = title;
            Description = description;
            GithubUri = githubUri;
            Articles = articles;
        }

        public string Title { get; }

        public string Description { get; }

        public Uri? GithubUri { get; }

        public ArticleModel[]? Articles { get; }
    }
}
