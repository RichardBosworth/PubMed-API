using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PubMed.Model.Database;
using PubMed.Model.Links;
using PubMed.Model.Links.Internal;
using PubMed.Search.Urls;
using RestSharp.Portable;

namespace PubMed.Search.Links
{
    public class FullTextLinkRetriever : IFullTextLinkRetriever
    {
        public async Task<FullTextLinkOptions> RetrieveFullTextLinkOptionsAsync(EntrezDatabase database, string paperID)
        {
            var restClient = new RestClient(ServiceURLs.ELinkBaseURL);

            var restRequest = new RestRequest();
            restRequest.AddParameter("dbfrom", database.ValidEntrezName.ToLower(), ParameterType.QueryString);
            restRequest.AddParameter("retmode", "xml", ParameterType.QueryString);
            restRequest.AddParameter("id", paperID, ParameterType.QueryString);
            restRequest.AddParameter("cmd", "prlinks", ParameterType.QueryString);

            // Get the response.
            var buildUri = restClient.BuildUri(restRequest);
            buildUri.ToString();
            var response = await restClient.Execute(restRequest);
            var rawBytes = response.RawBytes;
            var result = Encoding.UTF8.GetString(rawBytes, 0, rawBytes.Length);

            // Deserialize the XML result.
            var deserializer = new XmlSerializer(typeof (eLinkResult));
            eLinkResult deserializedObject;
            using (var stringReader = new StringReader(result))
            {
                deserializedObject = deserializer.Deserialize(stringReader) as eLinkResult;
            }

            // Construct the link results.
            var fullTextLinkOptions = new FullTextLinkOptions();
            foreach (var paperFullTextInfo in deserializedObject.LinkSet.IdUrlList)
            {
                if (paperFullTextInfo.ObjUrl != null)
                {
                    if (paperFullTextInfo.ObjUrl.Url != null)
                    {
                        var fullTextLink = new FullTextLink();
                        var linkUrl = paperFullTextInfo.ObjUrl.Url;
                        fullTextLink.UrlToFullText = linkUrl;

                        if (paperFullTextInfo.ObjUrl.Provider != null)
                        {
                            var provider = paperFullTextInfo.ObjUrl.Provider;
                            fullTextLink.Provider = new FullTextLinkProvider
                                                    {
                                                        Name = provider.Name,
                                                        NameAbbr = provider.NameAbbr,
                                                        Url = provider.Url.Value,
                                                        Id = provider.Id.ToString()
                                                    };
                        }

                        fullTextLinkOptions.Add(fullTextLink);
                    }
                }
            }

            return fullTextLinkOptions;
        }
    }
}