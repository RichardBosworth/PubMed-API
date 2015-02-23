namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Names of principal investigator(s) or collaborators who contributed to the research. Search names following the
    ///     author field format, e.g., soller b [ir]
    /// </summary>
    public class InvestigatorTerm : SearchTerm
    {
        public InvestigatorTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "IR"; }
        }
    }
}