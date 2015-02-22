using System.Threading.Tasks;
using PubMed.Model.Abstract;

namespace PubMed.Search.Abstract
{
    /// <summary>
    /// Provides functionality to retrieve the plain text abstract of a published paper.
    /// </summary>
    public interface IPaperAbstractRetriever
    {
        Task<string> GetAbstractOfPaperAsync(AbstractRetrievalProperties retrievalProperties);
    }
}