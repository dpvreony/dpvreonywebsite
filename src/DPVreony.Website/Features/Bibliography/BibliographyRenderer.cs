using System;

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
            return journalArticle.ToString();
        }

        private static string RenderBook(HarvardBook book)
        {
            return book.ToString();
        }

        private static string RenderWebPage(HarvardWebPage webPage)
        {
            return webPage.ToString();
        }
    }
}
