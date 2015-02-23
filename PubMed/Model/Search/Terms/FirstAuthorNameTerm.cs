namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The first personal author name in a citation.
    /// </summary>
    public class FirstAuthorNameTerm : SearchTerm
    {
        public FirstAuthorNameTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "1AU"; }
        }
    }
}