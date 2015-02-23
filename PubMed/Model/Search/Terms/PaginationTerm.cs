namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Enter only the first page number that the article appears on. The citation will display the full pagination of the
    ///     article but this field is searchable using only the first page number.
    /// </summary>
    public class PaginationTerm : SearchTerm
    {
        public PaginationTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PG"; }
        }
    }
}