using System.Collections.Generic;

namespace PubMed.Model.Database.Statistics
{
    internal class Header
    {
        public string type { get; set; }
        public string version { get; set; }
    }

    internal class Fieldlist
    {
        public string name { get; set; }
        public string fullname { get; set; }
        public string description { get; set; }
        public string termcount { get; set; }
        public string isdate { get; set; }
        public string isnumerical { get; set; }
        public string singletoken { get; set; }
        public string hierarchy { get; set; }
        public string ishidden { get; set; }
        public string istruncatable { get; set; }
        public string israngable { get; set; }
    }

    internal class Linklist
    {
        public string name { get; set; }
        public string menu { get; set; }
        public string description { get; set; }
        public string dbto { get; set; }
    }

    internal class Dbinfo
    {
        public string dbname { get; set; }
        public string menuname { get; set; }
        public string description { get; set; }
        public string dbbuild { get; set; }
        public string count { get; set; }
        public string lastupdate { get; set; }
        public List<Fieldlist> fieldlist { get; set; }
        public List<Linklist> linklist { get; set; }
    }

    internal class Edbinforesult
    {
        public Dbinfo dbinfo { get; set; }
    }

    internal class DatabaseStatisticsRootObject
    {
        public Header header { get; set; }
        public Edbinforesult einforesult { get; set; }
    }
}