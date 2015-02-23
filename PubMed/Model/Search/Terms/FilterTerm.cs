namespace PubMed.Model.Search.Terms
{
    public class FilterTerm : SearchTerm
    {
        public FilterTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "FILTER"; }
        }
    }
}