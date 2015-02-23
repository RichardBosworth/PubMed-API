namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     A MeSH term that is one of the main topics discussed in the article denoted by an asterisk on the MeSH term or
    ///     MeSH/Subheading combination, e.g., Cytokines/physiology* See MeSH Terms [MH] below.
    /// </summary>
    public class MeSHMajorTopicTerm : SearchTerm
    {
        public MeSHMajorTopicTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "MAJR"; }
        }
    }
}