namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Describes the type of material the article represents (e.g., Review, Clinical Trial, Retracted Publication,
    ///     Letter); see the PubMed Publication Types, e.g., review[pt]. Publication Types are arranged hierarchically with
    ///     more specific terms arranged beneath broader terms. Publication types automatically include the more specific
    ///     publication types in a search. To turn off this automatic feature, use the search syntax [pt:noexp], e.g., review
    ///     [pt:noexp].
    /// </summary>
    public class PublicationTypeTerm : SearchTerm
    {
        public PublicationTypeTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PT"; }
        }
    }
}