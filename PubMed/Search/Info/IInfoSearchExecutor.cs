using System.Collections.Generic;
using System.Threading.Tasks;
using PubMed.Model.Database;

namespace PubMed.Search.Info
{
    public interface IInfoSearchExecutor
    {
        Task<List<string>> GetValidDatabaseNameListAsync();
        Task<EntrezDatabase> SearchDatabaseStatisticsAsync(string validDatabaseName);
    }
}