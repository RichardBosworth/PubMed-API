namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     To search for a PubMed Identifier (PMID), enter the ID with or without the search field tag [pmid]. You can search
    ///     for several PMIDs by entering each number in the search box separated by a space (e.g., 17170002 16381840); PubMed
    ///     will or the PMIDs together.
    /// </summary>
    public class PMIDTerm : SearchTerm
    {
        public PMIDTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PMID"; }
        }
    }
}