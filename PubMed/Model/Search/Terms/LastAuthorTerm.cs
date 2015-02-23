namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The last personal author name in a citation.
    /// </summary>
    public class LastAuthorTerm : SearchTerm
    {
        public LastAuthorTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "LA"; }
        }
    }
}