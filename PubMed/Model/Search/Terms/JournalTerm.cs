namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The journal search field includes the journal title abbreviation, full journal title, or ISSN number (e.g., J Biol
    ///     Chem, Journal of Biological Chemistry, 0021-9258). If a journal title contains special characters, e.g.,
    ///     parentheses, brackets, enter the name without these characters, e.g., enter J Hand Surg [Am] as J Hand Surg Am.
    /// </summary>
    public class JournalTerm : SearchTerm
    {
        public JournalTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "Journal"; }
        }
    }
}