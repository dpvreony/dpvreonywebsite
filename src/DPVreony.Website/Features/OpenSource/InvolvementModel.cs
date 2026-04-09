using System;

namespace DPVreony.Website.Features.OpenSource
{
    public sealed class InvolvementModel
    {
        public InvolvementModel(
            string title,
            string description,
            GithubProjectModel? githubProject,
            ArticleModel[]? articles)
        {
            Title = title;
            Description = description;
            GithubProject = githubProject;
            Articles = articles;
        }

        public string Title { get; }

        public string Description { get; }

        public GithubProjectModel? GithubProject { get; }

        public ArticleModel[]? Articles { get; }
    }
}
