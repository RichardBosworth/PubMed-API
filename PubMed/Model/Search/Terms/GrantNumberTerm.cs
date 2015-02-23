namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     <para>
    ///         The grant number search field includes research grant numbers, contract numbers, or both that designate
    ///         financial support by agencies of the US PHS (Public Health Service), and other national or international
    ///         funding sources. The four parts of the grant data are:
    ///     </para>
    ///     <list type="number">
    ///         <item>number, e.g., LM05545</item>
    ///         <item>PHS 2-character grant abbreviation, e.g., LM</item>
    ///         <item>institute acronym, e.g., NLM NIH HHS</item>
    ///         <item>country, e.g., United States</item>
    ///     </list>
    ///     <para>Each individual grant part can be searched using [gr], e.g., NIH[gr]</para>
    /// </summary>
    public class GrantNumberTerm : SearchTerm
    {
        public GrantNumberTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "GR"; }
        }
    }
}