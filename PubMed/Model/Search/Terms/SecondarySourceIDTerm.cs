namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     <para>
    ///         The SI field identifies secondary source databanks and accession numbers, e.g., GenBank, GEO, PubChem,
    ///         ClinicalTrials.gov, ISRCTN. The field is composed of the source followed by a slash followed by an accession
    ///         number and can be searched with one or both components, e.g., genbank [si], AF001892 [si], genbank/AF001892
    ///         [si]. To retrieve all citations with an SI value, search hasdatabanklist.
    ///     </para>
    ///     <para>
    ///         The SI field and the NCBI sequence database links are not linked. The PubMed links to these databases are
    ///         created from the reference field of the GenBank or GenPept flat file. These references include citations that
    ///         discuss the specific sequence presented in these flat files.
    ///     </para>
    /// </summary>
    public class SecondarySourceIDTerm : SearchTerm
    {
        public SecondarySourceIDTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "SI"; }
        }
    }
}