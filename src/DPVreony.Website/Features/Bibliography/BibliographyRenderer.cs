using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPVreony.Website.Features.Bibliography
{
    public sealed class BibliographyRenderer
    {
        public static string Render(AbstractHarvardReferenceModel reference)
        {
            return reference switch
            {
                HarvardBook book => RenderBook(book),
                HarvardJournalArticle journalArticle => RenderJournalArticle(journalArticle),
                HarvardWebPage webPage => RenderWebPage(webPage),
                _ => throw new ArgumentOutOfRangeException(nameof(reference), reference, null)
            };
        }

        private static string RenderJournalArticle(HarvardJournalArticle journalArticle)
        {
            return $"{GetAuthorsString(journalArticle.Authors)} ({journalArticle.Year}). <i>{journalArticle.Title}</i>. <i>{journalArticle.Journal}</i>.";
        }

        private static string RenderBook(HarvardBook book)
        {
            return $"{GetAuthorsString(book.Authors)} ({book.Year}). <i>{book.Title}</i>. {book.Publisher}.";
        }

        private static string RenderWebPage(HarvardWebPage webPage)
        {
            // Construct the HTML string for the Harvard web page reference
            var authorsString = GetAuthorsString(webPage.Authors);
            var stringBuilder = new StringBuilder();

            stringBuilder.Append($"{authorsString}");

            if (webPage.Year != null)
            {
                stringBuilder.Append($" ({webPage.Year})");
            }
            stringBuilder.Append($". <a href=\"{webPage.Url}\" target=\"_blank\" rel=\"noopener noreferrer\">{webPage.Title}</a>. Accessed on {webPage.Accessed:dd MMMM yyyy}.");

            return stringBuilder.ToString();
        }

        private static string GetAuthorsString(IEnumerable<HarvardAuthorModel> authors)
        {
            return string.Join(
                ", ",
                authors.Select(a => string.IsNullOrWhiteSpace(a.GivenNames) ? a.FamilyName : $"{a.FamilyName}, {a.GivenNames}"));
        }
    }
}
