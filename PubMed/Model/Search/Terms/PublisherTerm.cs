namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Includes publisher names for Bookshelf citations.
    /// </summary>
    public class PublisherTerm : SearchTerm
    {
        public PublisherTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PUBN"; }
        }
    }
}