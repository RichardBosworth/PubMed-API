using System.Threading.Tasks;
using PubMed.Model.Abstract;
using PubMed.Search.Urls;
using RestSharp.Portable;
using Xamarin.Forms;

namespace PubMed.Search.Abstract
{
    public class PaperAbstractRetriever : IPaperAbstractRetriever
    {
        public async Task<string> GetAbstractOfPaperAsync(AbstractRetrievalProperties retrievalProperties)
        {
            var restClient = new RestClient(ServiceURLs.EFetchBaseURL);

            var restRequest = new RestRequest();
            restRequest.AddParameter("db", retrievalProperties.Database.ValidEntrezName.ToLower());
            restRequest.AddParameter("retmode", "text");
            restRequest.AddParameter("rettype", "abstract");
            restRequest.AddParameter("id", retrievalProperties.PaperID);

            var response = await restClient.Execute(restRequest);
            var rawBytes = response.RawBytes;
            string result = System.Text.Encoding.UTF8.GetString(rawBytes, 0, rawBytes.Length);
            return result;
        }
    }
}