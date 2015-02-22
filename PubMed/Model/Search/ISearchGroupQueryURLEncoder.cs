namespace PubMed.Model.Search
{
    public interface ISearchGroupQueryURLEncoder
    {
        string BuildQuery(SearchTermGroup baseGroup);
    }

    public class BasicSearchGroupQueryUrlEncoder : ISearchGroupQueryURLEncoder
    {
        public string BuildQuery(SearchTermGroup baseGroup)
        {
            return baseGroup.ToString();
        }
    }
}