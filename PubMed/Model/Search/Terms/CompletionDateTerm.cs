namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The date NLM completed processing the citation. Completon Date is not included in All Fields retrieval; the [dcom]
    ///     search tag is required.
    /// </summary>
    public class CompletionDateTerm : SearchTerm
    {
        public CompletionDateTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "DCOM"; }
        }
    }
}