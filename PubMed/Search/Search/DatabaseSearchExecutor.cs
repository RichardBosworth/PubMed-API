using System;
using System.Threading.Tasks;
using PubMed.Model.Search;
using PubMed.Model.Search.Internals;
using PubMed.Search.Urls;
using RestSharp.Portable;

namespace PubMed.Search.Search
{
    public class DatabaseSearchExecutor : IDatabaseSearchExecutor
    {
        public async Task<SearchResults> ExecuteSearchAsync(SearchProperties searchProperties)
        {
            // Ensure that search properties have been set.
            if (searchProperties == null) throw new ArgumentNullException("searchProperties");

            // Generate the request.
            var restClient = new RestClient(ServiceURLs.ESearchBaseURL);

            var restRequest = new RestRequest();
            restRequest.AddParameter("db", searchProperties.Database.ValidEntrezName.ToLower(), ParameterType.QueryString);
            restRequest.AddParameter("retmode", "json", ParameterType.QueryString);
            restRequest.AddParameter("retstart", searchProperties.StartIndex, ParameterType.QueryString);
            restRequest.AddParameter("retmax", searchProperties.MaximumResults, ParameterType.QueryString);
            if (searchProperties.RelDate != null)
            {
                restRequest.AddParameter("reldate", searchProperties.RelDate, ParameterType.QueryString);
            }

            // Encode and add the term string.
            ISearchGroupQueryURLEncoder urlEncoder = new BasicSearchGroupQueryUrlEncoder();
            var searchString = urlEncoder.BuildQuery(searchProperties.BaseSearchTermGroup);
            restRequest.AddParameter("term", searchString, ParameterType.QueryString);

            // Execute the request.
            var response = await restClient.Execute<SearchRootObject>(restRequest);
            var idList = response.Data.esearchresult.idlist;

            // Generate the search results.
            var searchResults = new SearchResults();
            foreach (var id in idList)
            {
                searchResults.Add(new SearchResult {PubMedID = id});
            }

            // Return the search results.
            return searchResults;
        }
    }
}