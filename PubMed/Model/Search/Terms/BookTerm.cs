namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     The book search field includes book citations, e.g., genereviews [book].
    ///     <para>Use the following untagged searches to retrieve all book or book chapters, e.g., ataxia AND pmcbookchapter</para>
    ///     <para>books and chapters: pmcbook</para>
    ///     <para>books: pmcbooktitle</para>
    ///     <para>book chapters: pmcbookchapter</para>
    /// </summary>
    public class BookTerm : SearchTerm
    {
        public BookTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "book"; }
        }
    }
}