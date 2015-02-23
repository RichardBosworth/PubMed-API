namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     <para>
    ///         Date the citation was added to the PubMed database. Exceptions: As of December 15, 2008, citations added to
    ///         PubMed more than twelve months after the date of publication have the EDAT set to the date of publication,
    ///         except for book citations. Prior to this, the Entrez Date was set to the Publication Date on citations
    ///         published before September 1997. Entrez Date is not included in All Fields retrieval; the [edat] search tag is
    ///         required.
    ///     </para>
    ///     <para>Search results are displayed in Entrez Date order, i.e., last in, first out.</para>
    ///     <para>
    ///         To search for a date range, insert a colon (:) between each date, e.g., 1996:1997 [edat] or 1998/01:1998/04
    ///         [edat].
    ///     </para>
    ///     <para>
    ///         Note: The Entrez Date is not changed to reflect the date a publisher supplied record is elevated to in
    ///         process or when an in process record is elevated to indexed for MEDLINE.
    ///     </para>
    /// </summary>
    public class EntrezDateTerm : SearchTerm
    {
        public EntrezDateTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "EDAT"; }
        }
    }
}