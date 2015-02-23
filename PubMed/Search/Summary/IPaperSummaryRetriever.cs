using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PubMed.Model.Summaries;
using PubMed.Model.Summaries.Internal;
using PubMed.Model.Summaries.Parsing;
using PubMed.Search.Urls;
using RestSharp.Portable;

namespace PubMed.Search.Summary
{
    public interface IPaperSummaryRetriever
    {
        Task<Model.Summaries.Summary> RetrievePaperSummaryAsync(SummaryRetrievalProperties retrievalProperties);
    }

    public class PaperSummaryRetriever : IPaperSummaryRetriever
    {
        public async Task<Model.Summaries.Summary> RetrievePaperSummaryAsync(SummaryRetrievalProperties retrievalProperties)
        {
            var restClient = new RestClient(ServiceURLs.ESummaryBaseURL);

            var restRequest = new RestRequest();
            restRequest.AddParameter("db", retrievalProperties.Database.ValidEntrezName.ToLower(), ParameterType.QueryString);
            restRequest.AddParameter("retmode", "xml", ParameterType.QueryString);
            restRequest.AddParameter("rettype", "abstract", ParameterType.QueryString);
            restRequest.AddParameter("id", retrievalProperties.PaperID, ParameterType.QueryString);

            // Get the response.
            var response = await restClient.Execute(restRequest);
            var rawBytes = response.RawBytes;
            var result = Encoding.UTF8.GetString(rawBytes, 0, rawBytes.Length);

            // Deserialize the XML result.
            var deserializer = new XmlSerializer(typeof (eSummaryResult));
            eSummaryResult deserializedObject;
            using (var stringReader = new StringReader(result))
            {
                deserializedObject = (eSummaryResult) deserializer.Deserialize(stringReader);
            }
            ISummaryInternalClassToPublicConverter converter = new SummaryInternalClassToPublicConverter();
            return converter.Convert(deserializedObject);
        }
    }
}