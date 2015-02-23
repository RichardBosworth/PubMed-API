using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PubMed.Model.Database;
using PubMed.Model.Database.Statistics;
using PubMed.Search.Urls;
using RestSharp.Portable;

namespace PubMed.Search.Info
{
    public class DatabaseInfoSearchExecutor : IInfoSearchExecutor
    {
        public async Task<List<string>> GetValidDatabaseNameListAsync()
        {
            RestClient restClient = new RestClient(ServiceURLs.ELinkBaseURL);
            RestRequest restRequest = new RestRequest();
            restRequest.AddParameter("retmode", "json");
            var restResponse = await restClient.Execute<InfoSearchRootObject>(restRequest);
            return restResponse.Data.einforesult.dblist;
        }

        public async Task<EntrezDatabase> SearchDatabaseStatisticsAsync(string validDatabaseName)
        {
            RestClient restClient = new RestClient(ServiceURLs.EInfoBaseURL);

            RestRequest restRequest = new RestRequest();
            restRequest.AddParameter("db", validDatabaseName.ToLower());
            restRequest.AddParameter("retmode", "json");

            var response = await restClient.Execute<DatabaseStatisticsRootObject>(restRequest);
            var databaseInfo = response.Data.einforesult.dbinfo;

            EntrezDatabase entrezDatabase = new EntrezDatabase(databaseInfo.dbname);
            entrezDatabase.DatabaseDescription = databaseInfo.description;
            entrezDatabase.LastUpdate = DateTime.Parse(databaseInfo.lastupdate);

            return entrezDatabase;
        }
    }
}