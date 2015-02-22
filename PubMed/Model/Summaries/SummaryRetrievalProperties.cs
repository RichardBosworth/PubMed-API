using PubMed.Model.Database;

namespace PubMed.Model.Summaries
{
    public class SummaryRetrievalProperties
    {
        public SummaryRetrievalProperties(EntrezDatabase database, string paperID)
        {
            Database = database;
            PaperID = paperID;
        }

        public EntrezDatabase Database { get; set; }
        public string PaperID { get; set; }
    }
}