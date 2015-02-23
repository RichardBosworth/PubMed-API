namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The NLM ID is the alpha-numeric identifier for the cited journal that was assigned by the NLM Integrated Library
    ///     System LocatorPlus, e.g., 0375267 [jid].
    /// </summary>
    public class NLMUniqueIDTerm : SearchTerm
    {
        public NLMUniqueIDTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "JID"; }
        }
    }
}