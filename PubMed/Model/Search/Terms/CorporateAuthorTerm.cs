namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Corporate author identifies the corporate or collective authorship of an article. Corporate names display exactly
    ///     as they appear in the journal.
    ///     Note: Citations indexed pre-2000 and some citations indexed in 2000-2001 retain corporate authors at the end of the
    ///     title field. For comprehensive searches, consider including terms and/or words searched in the title field [ti].
    /// </summary>
    public class CorporateAuthorTerm : SearchTerm
    {
        public CorporateAuthorTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "CN"; }
        }
    }
}