namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The index for the article's full investigator or collaborator name, if available. Full investigator searching can
    ///     be searched in natural or inverted order, e.g., harry janes or janes harry.
    /// </summary>
    public class FullInvestigatorNameTerm : SearchTerm
    {
        public FullInvestigatorNameTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "FIR"; }
        }
    }
}