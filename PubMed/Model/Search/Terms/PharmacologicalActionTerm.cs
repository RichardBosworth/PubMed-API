namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Substances known to have a particular pharmacologic action. Each pharmacologic action term index is created with
    ///     the drug/substance terms known to have that effect. This includes both MeSH terms and terms for Supplementary
    ///     Concept Records.
    /// </summary>
    public class PharmacologicalActionTerm : SearchTerm
    {
        public PharmacologicalActionTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PA"; }
        }
    }
}