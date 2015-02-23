namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The number of the journal issue in which the article was published.
    /// </summary>
    public class IssueTerm : SearchTerm
    {
        public IssueTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "IP"; }
        }
    }
}