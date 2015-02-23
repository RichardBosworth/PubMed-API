namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     <para>
    ///         The date the citation was indexed with MeSH Terms and elevated to MEDLINE for citations with an Entrez Date
    ///         after March 4, 2000. The MeSH Date is initially set to the Entrez Date when the citation is added to PubMed. If
    ///         the MeSH Date and Entrez Date on a citation are the same, and the Entrez Date is after March 4, 2000, the
    ///         citation has not yet been indexed. MeSH Date is not included in All Fields retrieval; the [mhda] search tag is
    ///         required.
    ///     </para>
    ///     <para>
    ///         Dates must be entered using the format YYYY/MM/DD [mhda], e.g. 2000/03/15 [mhda]. The month and day are
    ///         optional (e.g., 2000 [mhda] or 2000/03 [mhda]).
    ///     </para>
    ///     <para>
    ///         To enter a date range, insert a colon (:) between each date, e.g., 1999:2000 [mhda] or 2000/03:2000/04
    ///         [mhda].
    ///     </para>
    /// </summary>
    public class MeSHDateTerm : SearchTerm
    {
        public MeSHDateTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "MHDA"; }
        }
    }
}