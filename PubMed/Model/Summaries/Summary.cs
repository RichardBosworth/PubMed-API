using System;
using System.Collections.Generic;

namespace PubMed.Model.Summaries
{
    public class Summary
    {
        public Summary()
        {
            AuthorList = new List<Author>();
            History = new List<History>();
            ArticleIDs = new List<ArticleID>();
            LangList = new List<string>();
        }

        public string ID { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public DateTime? PubDate { get; set; }
        public DateTime? EPubDate { get; set; }
        public List<Author> AuthorList { get; set; }
        public List<History> History { get; set; }
        public List<ArticleID> ArticleIDs { get; set; }
        public string LastAuthor { get; set; }
        public List<string> LangList { get; set; }
        public string Volume { get; set; }
        public string Issue { get; set; }
        public string Pages { get; set; }
        public string NlmUniqueID { get; set; }
        public string ISSN { get; set; }
        public string ESSN { get; set; }
        public List<string> PubTypeList { get; set; }
        public string RecordStatus { get; set; }
        public string PubStatus { get; set; }
        public string DOI { get; set; }
        public int HasAbstract { get; set; }
        public int PmcRefCount { get; set; }
        public string FullJournalName { get; set; }
        public string ELocationID { get; set; }
        public string SO { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class History
    {
        public string HistoryEntryType { get; set; }
        public DateTime? Date { get; set; }
    }

    public class ArticleID
    {
        public string IDKey { get; set; }
        public string IDValue { get; set; }
    }
}