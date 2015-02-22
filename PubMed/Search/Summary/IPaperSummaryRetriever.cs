using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PubMed.Model.Summaries;
using PubMed.Search.Urls;
using RestSharp.Portable;
using Xamarin.Forms;

namespace PubMed.Search.Summary
{
    public interface IPaperSummaryRetriever
    {
        Task<Model.Summaries.Summary> RetrievePaperSummary(SummaryRetrievalProperties retrievalProperties);
    }

    public class PaperSummaryRetriever : IPaperSummaryRetriever
    {
        public async Task<Model.Summaries.Summary> RetrievePaperSummary(SummaryRetrievalProperties retrievalProperties)
        {
            try
            {
                var restClient = new RestClient(ServiceURLs.ESummaryBaseURL);

                var restRequest = new RestRequest();
                restRequest.AddParameter("db", retrievalProperties.Database.ValidEntrezName.ToLower(), ParameterType.QueryString);
                restRequest.AddParameter("retmode", "json", ParameterType.QueryString);
                restRequest.AddParameter("rettype", "abstract", ParameterType.QueryString);
                restRequest.AddParameter("id", retrievalProperties.PaperID, ParameterType.QueryString);

                // Get the response.
                var buildUri = restClient.BuildUri(restRequest);
                var response = await restClient.Execute(restRequest);
                var rawBytes = response.RawBytes;
                var result = Encoding.UTF8.GetString(rawBytes, 0, rawBytes.Length);

                var jObject = JObject.Parse(result);
                dynamic data = jObject["result"][retrievalProperties.PaperID];

                var summary = new Model.Summaries.Summary();
                summary.UID = data.uid;
                summary.PublishDate = data.pubdate;
                summary.EPublishDate = (string) data.epubdate;
                summary.Source = data.source;

                summary.Authors = new List<Author>();
                var authors = data.authors;
                foreach (var author in authors)
                {
                    summary.Authors.Add(new Author(){Name = author.name, AuthType = author.authtype, ClusterId = author.clusterid});
                }

                summary.LastAuthor = data.lastauthor;

                summary.Title = data.title;
                summary.SortTitle = data.sorttitle;
                summary.Volume = data.volume;
                summary.Issue = data.issue;
                summary.Pages = data.pages;
                summary.NlmUniqueID = data.nlmuniqueid;
                summary.ISSN = data.issn;
                summary.ESSN = data.essn;

                if (((JArray)data.pubtype).Count > 0)
                {
                    summary.PublicationTypes = ((JArray) data.pubtype).ToObject<List<string>>();
                }
                summary.RecordStatus = data.recordstatus;
                summary.PubStatus = data.pubstatus;

                if (((JArray)data.articleids).Count > 0)
                {
                    summary.ArticleIDs = ((JArray) data.articleids).ToObject<List<ArticleID>>();
                }
                if (((JArray)data.history).Count > 0)
                {
                    summary.PublicationHistoryList = ((JArray) data.history).ToObject<List<History>>();
                }
                if (((JArray)data.attributes).Count > 0)
                {
                    summary.Attributes = ((JArray) data.attributes).ToObject<List<string>>();
                }
                summary.PMCrefCount = data.pmcrefcount;
                summary.FullJournalName = data.fulljournalname;
                summary.ELocationID = data.elocationid;
                summary.ViewCount = data.viewcount;
                summary.DocType = data.doctype;

                return summary;
            }
            catch (Exception e)
            {
                throw new SummaryRetrievalException();
            }
        }
    }
}