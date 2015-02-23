namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     MeSH Subheadings are used with MeSH terms to help describe more completely a particular aspect of a subject. For
    ///     example, the drug therapy of asthma is displayed as asthma/drug therapy.
    /// </summary>
    public class MeSHSubheadingsTerm : SearchTerm
    {
        public MeSHSubheadingsTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "SH"; }
        }
    }
}