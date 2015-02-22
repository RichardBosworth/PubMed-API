namespace PubMed.Model.Search
{
    /// <summary>
    /// Determines the link type of search term. For example, this is either AND, OR or NOT.
    /// </summary>
    public class SearchTermLinkType
    {
        private LinkTypes _linkType;

        public SearchTermLinkType(LinkTypes linkType)
        {
            _linkType = linkType;
        }

        public override string ToString()
        {
            return string.Format("{0}", _linkType);
        }
    }

    public enum LinkTypes
    {
        AND,
        OR,
        NOT
    }
}