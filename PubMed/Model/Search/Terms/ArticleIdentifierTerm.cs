namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Includes article identifiers submitted by journal publishers such as doi (digital object identifier). These data
    ///     are typically used for generating LinkOut links.
    /// </summary>
    public class ArticleIdentifierTerm : SearchTerm
    {
        public ArticleIdentifierTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "AID"; }
        }
    }
}