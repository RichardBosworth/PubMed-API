using System.Collections.Generic;

namespace PubMed.Model.Database
{
    internal class Header
    {
        public string type { get; set; }
        public string version { get; set; }
    }

    internal class Einforesult
    {
        public List<string> dblist { get; set; }
    }

    internal class InfoSearchRootObject
    {
        public Header header { get; set; }
        public Einforesult einforesult { get; set; }
    }
}