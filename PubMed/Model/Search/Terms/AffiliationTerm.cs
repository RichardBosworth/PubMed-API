namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Affiliation may be included for authors, corporate authors and investigators, e.g., cleveland [ad] AND clinic [ad],
    ///     if submitted by the publisher. Multiple affiliations were added to citations starting from 2014, previously only
    ///     the first author’s affiliation was included.
    /// </summary>
    public class AffiliationTerm : SearchTerm
    {
        public AffiliationTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "AD"; }
        }
    }
}