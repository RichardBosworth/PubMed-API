namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The author identifier includes a unique identifier associated with an author, corporate or investigator name, if
    ///     supplied by a publisher. The field includes the the organization authority that established the unique identifier,
    ///     such as, ORCID, ISNI, VIAF, e.g., orcid 0000-0001-5027-4446 [auid].
    /// </summary>
    public class AuthorIdentifierTerm : SearchTerm
    {
        public AuthorIdentifierTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "AUID"; }
        }
    }
}