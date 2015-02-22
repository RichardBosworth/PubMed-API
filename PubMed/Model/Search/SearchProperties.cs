using PubMed.Model.Database;

namespace PubMed.Model.Search
{
    public class SearchProperties
    {
        public SearchProperties()
        {
            MaximumResults = 1000;
            StartIndex = 0;
        }

        /// <summary>
        /// Gets and sets the database that will be searched.
        /// </summary>
        public EntrezDatabase Database { get; set; }

        /// <summary>
        /// Total number of UIDs from the retrieved set to be shown in the XML output (default=20). By default, ESearch only includes the first 20 UIDs retrieved in the XML output. If usehistory is set to 'y', the remainder of the retrieved set will be stored on the History server; otherwise these UIDs are lost. Increasing retmax allows more of the retrieved UIDs to be included in the XML output, up to a maximum of 100,000 records. To retrieve more than 100,000 UIDs, submit multiple esearch requests while incrementing the Value of retstart (see Application 3).
        /// </summary>
        public int MaximumResults { get; set; }

        /// <summary>
        /// Sequential index of the first UID in the retrieved set to be shown in the XML output (default=0, corresponding to the first record of the entire set). This parameter can be in conjunction with retmax to download an arbitrary subset of UIDs retrieved from a search.
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// When reldate is set to an integer n, the search returns only those items that have a date specified by datetype within the last n days.
        /// </summary>
        public int? RelDate { get; set; }

        /// <summary>
        /// Gets and sets the base search term group for the search query.
        /// </summary>
        public SearchTermGroup BaseSearchTermGroup { get; set; }
    }
}