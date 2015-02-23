namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Words and numbers included in a citation's title, collection title, abstract, and other abstract. English language
    ///     abstracts are taken directly from the published article. If an article does not have a published abstract, NLM does
    ///     not create one.
    /// </summary>
    public class TitleOrAbstractTerm : SearchTerm
    {
        public TitleOrAbstractTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "TIAB"; }
        }
    }
}