namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The ISBN for book or book chapters.
    /// </summary>
    public class ISBNTerm : SearchTerm
    {
        public ISBNTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "ISBN"; }
        }
    }
}