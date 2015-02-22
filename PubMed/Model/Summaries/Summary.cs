using System;
using System.Collections.Generic;

namespace PubMed.Model.Summaries
{
    public class Summary
    {
        public Summary()
        {
            Authors = new List<Author>();
        }

        public string UID { get; set; }
        public string PublishDate { get; set; }
        public string EPublishDate { get; set; }
        public string Source { get; set; }
        public List<Author> Authors { get; set; }
        public string LastAuthor { get; set; }
        public string Title { get; set; }
        public string SortTitle { get; set; }
        public string Volume { get; set; }
        public string Issue { get; set; }
        public string Pages { get; set; }
        public string NlmUniqueID { get; set; }
        public string ISSN { get; set; }
        public string ESSN { get; set; }
        public List<string> PublicationTypes { get; set; }
        public string RecordStatus { get; set; }
        public string PubStatus { get; set; }
        public List<ArticleID> ArticleIDs { get; set; }
        public List<History> PublicationHistoryList { get; set; }
        public List<string> Attributes { get; set; }
        public int PMCrefCount { get; set; }
        public string FullJournalName { get; set; }
        public string ELocationID { get; set; }
        public int ViewCount{ get; set; }
        public string DocType { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public string AuthType { get; set; }
        public string ClusterId { get; set; }
    }


    public class ArticleID
    {
        public string IdType { get; set; }
        public int IdTypeN { get; set; }
        public string Value { get; set; }
    }


    public class History
    {
        public string PubStatus { get; set; }
        public string Date { get; set; }
    }
}