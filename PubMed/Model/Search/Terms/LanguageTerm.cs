namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The language search field includes the language in which the article was published. Note that many non-English
    ///     articles have English language abstracts. You may search using either the language or the first three characters of
    ///     most languages, e.g., chi [la] retrieves the same results as chinese [la]. The most notable exception is jpn [la]
    ///     for Japanese.
    /// </summary>
    public class LanguageTerm : SearchTerm
    {
        public LanguageTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "LA"; }
        }
    }
}