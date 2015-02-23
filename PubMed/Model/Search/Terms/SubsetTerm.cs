namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The subset field is a method of restricting retrieval by subject, citation status and journal category, with the
    ///     search tag [SB]. See also filters and Finding Related Links for a Citation Using LinkOut.
    /// </summary>
    public class SubsetTerm : SearchTerm
    {
        public SubsetTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "SB"; }
        }
    }
}