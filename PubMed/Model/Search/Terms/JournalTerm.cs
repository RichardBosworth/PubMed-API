namespace PubMed.Model.Search.Terms
{
    public class JournalTerm :SearchTerm
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