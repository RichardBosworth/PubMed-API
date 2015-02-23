namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Words and numbers in title originally published in a non-English language, in that language. Non-Roman alphabet
    ///     language titles are transliterated. Transliterated title is not included in All Fields or Text Word retrieval so
    ///     you must search terms using the [tt] search tag.
    /// </summary>
    public class TransliteratedTitleTerm : SearchTerm
    {
        public TransliteratedTitleTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "TT"; }
        }
    }
}