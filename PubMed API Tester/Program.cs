using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubMed.Model.Database;
using PubMed.Model.Search;
using PubMed.Model.Search.Terms;
using PubMed.Model.Summaries;
using PubMed.Search.Search;
using PubMed.Search.Summary;

namespace PubMed_API_Tester
{
    class Program
    {
        private static EntrezDatabase _entrezDatabase = new EntrezDatabase("pubmed");

        static void Main(string[] args)
        {
            SearchProperties searchProperties = BuildSearchProperties();

            ExecuteSearch(searchProperties);

            Console.ReadLine();
        }

        private static async void ExecuteSearch(SearchProperties searchProperties)
        {
            IDatabaseSearchExecutor databaseSearchExecutor = new DatabaseSearchExecutor();
            var searchResults = await databaseSearchExecutor.ExecuteSearchAsync(searchProperties);
            var count = searchResults.Count;
            Console.WriteLine(count);

            foreach (var result in searchResults)
            {
                IPaperSummaryRetriever paperSummaryRetriever = new PaperSummaryRetriever();
                var summary = await paperSummaryRetriever.RetrievePaperSummaryAsync(new SummaryRetrievalProperties(_entrezDatabase, result.PubMedID));
                Console.WriteLine(summary.LastAuthor);
            }

            Console.ReadLine();
        }

        private static SearchProperties BuildSearchProperties()
        {
            SearchProperties searchProperties = new SearchProperties();
            searchProperties.Database = _entrezDatabase;
            searchProperties.MaximumResults = 1000;
            searchProperties.RelDate = 90;
            searchProperties.BaseSearchTermGroup = BuildSearch();
            return searchProperties;
        }

        private static SearchTermGroup BuildSearch()
        {
            SearchTermGroup baseGroup = new SearchTermGroup();
            baseGroup.AddTerm<AllFieldsTerm>("implantable cardioverter defibrillator", LinkTypes.AND);

            return baseGroup;
        }
    }
}
