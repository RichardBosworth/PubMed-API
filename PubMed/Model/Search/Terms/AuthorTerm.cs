namespace PubMed.Model.Search.Terms
{
    public class AuthorTerm : SearchTerm
    {
        public AuthorTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "author"; }
        }
    }
}