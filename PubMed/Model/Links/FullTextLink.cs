using Newtonsoft.Json.Serialization;

namespace PubMed.Model.Links
{
    public class FullTextLink
    {
        public string UrlToFullText { get; set; }
        public FullTextLinkProvider Provider { get; set; }
    }

    public class FullTextLinkProvider
    {
        public string Name { get; set; }
        public string NameAbbr { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
    }
}