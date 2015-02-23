using System.Threading.Tasks;
using PubMed.Model.Database;
using PubMed.Model.Links;

namespace PubMed.Search.Links
{
    public interface IFullTextLinkRetriever
    {
        Task<FullTextLinkOptions> RetrieveFullTextLinkOptionsAsync(EntrezDatabase database, string paperID);
    }
}