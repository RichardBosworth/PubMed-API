namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Location ID includes the DOI or publisher ID that serves the role of pagination to locate an online article.
    /// </summary>
    public class LocationIDTerm : SearchTerm
    {
        public LocationIDTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "LID"; }
        }
    }
}