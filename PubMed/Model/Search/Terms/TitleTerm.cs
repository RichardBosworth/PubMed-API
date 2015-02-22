namespace PubMed.Model.Search.Terms
{
    public class TitleTerm : SearchTerm
    {
        public TitleTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "Title"; }
        }
    }
}