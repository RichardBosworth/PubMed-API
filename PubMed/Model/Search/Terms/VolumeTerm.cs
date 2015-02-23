namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The number of the journal volume in which an article is published.
    /// </summary>
    public class VolumeTerm : SearchTerm
    {
        public VolumeTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "VI"; }
        }
    }
}