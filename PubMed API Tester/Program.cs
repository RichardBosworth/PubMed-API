using System;
using System.Diagnostics;
using PubMed.Model.Database;
using PubMed.Model.Search;
using PubMed.Model.Search.Terms;
using PubMed.Model.Summaries;
using PubMed.Search.Links;
using PubMed.Search.Search;
using PubMed.Search.Summary;

namespace PubMed_API_Tester
{
    internal class Program
    {
        private static readonly EntrezDatabase _entrezDatabase = new EntrezDatabase("pubmed");

        private static void Main(string[] args)
        {
            var searchProperties = BuildSearchProperties();
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
                if (summary.AuthorList != null)
                {
                    if (summary.AuthorList.Count > 0)
                    {
                        Console.WriteLine(summary.Title);

                        IFullTextLinkRetriever fullTextLinkRetriever = new FullTextLinkRetriever();
                        var fullTextLinkOptions = await fullTextLinkRetriever.RetrieveFullTextLinkOptionsAsync(_entrezDatabase, summary.ID);
                        if (fullTextLinkOptions.Count > 0)
                        {
                            Process.Start("explorer.exe", fullTextLinkOptions[0].UrlToFullText);
                        }
                    }
                }
            }


            Console.ReadLine();
        }

        private static SearchProperties BuildSearchProperties()
        {
            var searchProperties = new SearchProperties();
            searchProperties.Database = _entrezDatabase;
            searchProperties.MaximumResults = 5;
            searchProperties.BaseSearchTermGroup = BuildSearch();
            return searchProperties;
        }

        private static SearchTermGroup BuildSearch()
        {
            var baseGroup = new SearchTermGroup();
            baseGroup.AddTerm<TitleTerm>("Children", LinkTypes.AND);
            baseGroup.AddTerm(new AuthorTerm("garfin"), LinkTypes.AND);

            var searchTermGroup = new SearchTermGroup {GroupLinkType = new SearchTermLinkType(LinkTypes.AND)};
            searchTermGroup.AddTerm<TitleOrAbstractTerm>("children", LinkTypes.OR);
            searchTermGroup.AddTerm<TitleOrAbstractTerm>("paediatric", LinkTypes.OR);
            baseGroup.Children.Add(searchTermGroup);

            baseGroup.AddTerm<TitleTerm>("Non-Hodgkin lymphoma", LinkTypes.NOT);

            return baseGroup;
        }
    }
}