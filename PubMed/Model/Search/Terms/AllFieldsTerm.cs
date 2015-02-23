namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Untagged terms and terms tagged with [all fields] are processed using Automatic Term Mapping. Terms that do not map
    ///     are searched in all search fields except for Place of Publication, Transliterated Title, Create Date, Completion
    ///     Date, Entrez Date, MeSH Date, and Modification Date. Terms enclosed in double quotes or truncated will be searched
    ///     in all fields and not processed using automatic term mapping. PubMed ignores stopwords.
    /// </summary>
    public class AllFieldsTerm : SearchTerm
    {
        public AllFieldsTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "All Fields"; }
        }
    }
}