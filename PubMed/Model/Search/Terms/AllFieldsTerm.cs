namespace PubMed.Model.Search.Terms
{
    public class AllFieldsTerm : SearchTerm
    {
        protected override string SearchTagString
        {
            get { return "All Fields"; }
        }

        public AllFieldsTerm(string term) : base(term)
        {
        }
    }
}