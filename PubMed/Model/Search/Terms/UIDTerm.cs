namespace PubMed.Model.Search.Terms
{
    public class UIDTerm : SearchTerm
    {
        public UIDTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PMID"; }
        }
    }
}