using System.Threading.Tasks;
using PubMed.Model.Search;

namespace PubMed.Search.Search
{
    public interface IDatabaseSearchExecutor
    {
        Task<SearchResults> ExecuteSearchAsync(SearchProperties searchProperties);
    }
}