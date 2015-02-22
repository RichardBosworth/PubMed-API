using System.Text;

namespace PubMed.Model.Search
{
    public abstract class SearchTerm
    {
        protected SearchTerm(string term)
        {
            Term = term;
            LinkType = new SearchTermLinkType(LinkTypes.AND);
        }

        /// <summary>
        ///     Gets and sets the actual text of the term.
        /// </summary>
        public string Term { get; set; }

        /// <summary>
        ///     The text that will be utilised by the ToString method to determine what tag the term will be used to search upon.
        ///     This is mainly for use by overriding classes, for convenience (so that they don't need to Overload the ToString
        ///     method).
        /// </summary>
        protected virtual string SearchTagString
        {
            get { return "All Fields"; }
        }

        /// <summary>
        /// Gets and sets the link type of the search term
        /// </summary>
        public SearchTermLinkType LinkType { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\"");
            stringBuilder.Append(Term.ToLower());
            stringBuilder.Append("\"");
            stringBuilder.Append("[");
            stringBuilder.Append(SearchTagString);
            stringBuilder.Append("]");

            return stringBuilder.ToString();
        }
    }
}