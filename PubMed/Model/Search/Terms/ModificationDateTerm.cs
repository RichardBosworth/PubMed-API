namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Modification date is a completed citation’s most recent revision date. Modification Date is not included in All
    ///     Fields retrieval; the [lr] search tag is required.
    /// </summary>
    public class ModificationDateTerm : SearchTerm
    {
        public ModificationDateTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "LR"; }
        }
    }
}