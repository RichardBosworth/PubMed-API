namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     <para>EC/RN numbers are assigned by:</para>
    ///     <para>
    ///         The Food and Drug Administration (FDA) Substance Registration System for Unique Ingredient Identifiers
    ///         (UNIIs), e.g., Y92OUS2H9B
    ///     </para>
    ///     <para>The Enzyme Commission (EC) to designate a particular enzyme, e.g., EC 1.1.1.57</para>
    ///     <para>The Chemical Abstracts Service (CAS) for Registry Numbers, e.g., 2751-14-6</para>
    ///     <para>
    ///         The EC/RN number search field includes both the Registry Number and the Related Registry Number (available in
    ///         the NLM MeSH Browser).
    ///     </para>
    /// </summary>
    public class ECRNNumberTerm : SearchTerm
    {
        public ECRNNumberTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "RN"; }
        }
    }
}