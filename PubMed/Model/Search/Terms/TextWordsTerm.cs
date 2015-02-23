namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Includes all words and numbers in the title, abstract, other abstract, MeSH terms, MeSH Subheadings, Publication
    ///     Types, Substance Names, Personal Name as Subject, Corporate Author, Secondary Source, Comment/Correction Notes, and
    ///     Other Terms (see Other Term [OT] above) typically non-MeSH subject terms (keywords), including NASA Space Flight
    ///     Mission, assigned by an organization other than NLM.
    /// </summary>
    public class TextWordsTerm : SearchTerm
    {
        public TextWordsTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "TW"; }
        }
    }
}