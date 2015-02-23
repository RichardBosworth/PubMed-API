namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The full author name for articles published from 2002 forward, if available. Full author searches can be entered in
    ///     natural or inverted order, e.g., julia s wong or wong julia s.
    /// </summary>
    public class FullAuthorNameTerm : SearchTerm
    {
        public FullAuthorNameTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "FAU"; }
        }
    }
}