using System;
using System.Collections.Generic;
using System.Text;

namespace PubMed.Model.Search
{
    /// <summary>
    ///     Models a group of search terms. This group translates to 'brackets' when executing a search. This is also used for
    ///     the base group of the search.
    /// </summary>
    public class SearchTermGroup
    {
        public SearchTermGroup()
        {
            Terms = new List<SearchTerm>();
            Children = new List<SearchTermGroup>();
            GroupLinkType = new SearchTermLinkType(LinkTypes.AND);
        }

        public List<SearchTerm> Terms { get; set; }
        public List<SearchTermGroup> Children { get; set; }
        public SearchTermLinkType GroupLinkType { get; set; }

        public void AddTerm<T>(string termText, LinkTypes linkType) where T : SearchTerm
        {
            var instance = (T) Activator.CreateInstance(typeof (T), termText);
            instance.LinkType = new SearchTermLinkType(linkType);
            instance.Term = termText;
            Terms.Add(instance);
        }

        public void AddTerm(SearchTerm term, LinkTypes linkType = LinkTypes.AND) 
        {
            term.LinkType = new SearchTermLinkType(linkType);
            Terms.Add(term);
        }

        public override string ToString()
        {
            var groupStringBuilder = new StringBuilder();

            if (Terms.Count > 1 || Children.Count>=1)
            {
                groupStringBuilder.Append("(");
            }
            groupStringBuilder.Append(" ");

            // Build terms.
            for (var index = 0; index < Terms.Count; index++)
            {
                var searchTerm = Terms[index];

                var searchTermBuilder = BuildTerm(index, searchTerm);

                // Add the search term to the larger group builder.
                groupStringBuilder.Append(searchTermBuilder);
                groupStringBuilder.Append(" ");
            }

            // Build sub-groups.
            for (var index = 0; index < Children.Count; index++)
            {
                var child = Children[index];

                if (index > 0)
                {
                    groupStringBuilder.Append(child.GroupLinkType);
                    groupStringBuilder.Append(" ");
                }
                else
                {
                    if (Terms.Count >= 1)
                    {
                        groupStringBuilder.Append(child.GroupLinkType);
                        groupStringBuilder.Append(" ");
                    }
                }
                

                var childText = child.ToString();

                groupStringBuilder.Append(childText);
                groupStringBuilder.Append(" ");
            }

            if (Terms.Count > 1 || Children.Count >= 1)
            {
                groupStringBuilder.Append(")");
            }

            // Return the build group.
            return groupStringBuilder.ToString();
        }

        private static StringBuilder BuildTerm(int index, SearchTerm searchTerm)
        {
            var searchTermBuilder = new StringBuilder();

            // Determine if it is the first search term (and therefore, no link type needs to be used), or if it is a last one.
            if (index > 0)
            {
                searchTermBuilder.Append(searchTerm.LinkType);
                searchTermBuilder.Append(" ");
            }

            // Apply the search term string representation.
            searchTermBuilder.Append(searchTerm);
            return searchTermBuilder;
        }
    }
}