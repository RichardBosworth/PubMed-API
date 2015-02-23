namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Indicates the cited journal's country of publication. Geographic place of publication regions are not searchable.
    ///     In order to retrieve records for all countries in a region (e.g., North America) it is necessary to OR together the
    ///     countries of interest. Note: This field is not included in all fields or text word retrieval.
    /// </summary>
    public class PlaceofPublicationTerm : SearchTerm
    {
        public PlaceofPublicationTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "PL"; }
        }
    }
}