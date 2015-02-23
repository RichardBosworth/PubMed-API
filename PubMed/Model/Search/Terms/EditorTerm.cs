namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The editor search field includes the editors for book or chapter citations.
    /// </summary>
    public class EditorTerm : SearchTerm
    {
        public EditorTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "ED"; }
        }
    }
}