using System;

namespace DPVreony.Website.Features.OpenSource
{
    public sealed class InvolvementModel
    {
        public InvolvementModel(
            string title,
            string description,
            Uri githubUri,
            Uri articleUri)
        {
            Title = title;
            Description = description;
            GithubUri = githubUri;
            ArticleUri = articleUri;
        }

        public string Title { get; }

        public string Description { get; }

        public Uri GithubUri { get; }

        public Uri ArticleUri { get; }
    }
}
