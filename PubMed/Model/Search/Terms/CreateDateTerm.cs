namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The date the citation record was first created. Create Date is not included in All Fields retrieval; the [crdt]
    ///     search tag is required.
    /// </summary>
    public class CreateDateTerm : SearchTerm
    {
        public CreateDateTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "CRDT"; }
        }
    }
}