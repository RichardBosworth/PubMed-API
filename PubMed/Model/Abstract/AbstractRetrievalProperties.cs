using PubMed.Model.Database;

namespace PubMed.Model.Abstract
{
    public class AbstractRetrievalProperties
    {
        public AbstractRetrievalProperties(EntrezDatabase database, string paperID)
        {
            Database = database;
            PaperID = paperID;
        }

        public EntrezDatabase Database { get; set; }
        public string PaperID { get; set; }
    }
}