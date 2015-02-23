namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Words and numbers included in the title of a citation, as well as the collection title for book citations.
    /// </summary>
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