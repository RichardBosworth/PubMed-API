using System.Collections.Generic;

namespace PubMed.Model.Search.Internals
{
    internal class Header
    {
        public string type { get; set; }
        public string version { get; set; }
    }

    internal class Translationset
    {
        public string from { get; set; }
        public string to { get; set; }
    }

    internal class Esearchresult
    {
        public string count { get; set; }
        public string retmax { get; set; }
        public string retstart { get; set; }
        public List<string> idlist { get; set; }
        public List<Translationset> translationset { get; set; }
        public List<object> translationstack { get; set; }
        public string querytranslation { get; set; }
    }

    internal class SearchRootObject
    {
        public Header header { get; set; }
        public Esearchresult esearchresult { get; set; }
    }
}