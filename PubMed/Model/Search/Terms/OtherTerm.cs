namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Mostly non-MeSH subject terms (keywords). The other term data may be marked with an asterisk to indicate a major
    ///     concept; however, asterisks are for display only. You cannot search other terms with a major concept tag. The OT
    ///     field is searchable with the text word [tw] and other term [ot] search tags. To retrieve citations that have
    ///     keywords, use the query haskeyword.
    /// </summary>
    public class OtherTerm : SearchTerm
    {
        public OtherTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "OT"; }
        }
    }
}