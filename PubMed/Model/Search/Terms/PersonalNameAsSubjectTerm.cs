namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Use this search field tag to limit retrieval to where the name is the subject of the article, e.g., varmus h[ps].
    ///     Search for personal names as subject using the author field format, e.g., varmus h[ps].
    /// </summary>
    public class PersonalNameAsSubjectTerm : SearchTerm
    {
        public PersonalNameAsSubjectTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PS"; }
        }
    }
}