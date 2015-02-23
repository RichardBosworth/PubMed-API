using System;

namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     Publication date is the date that the article was published.
    /// </summary>
    public class PublicationDateTerm : SearchTerm
    {
        public PublicationDateTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "DP"; }
        }

        public static PublicationDateTerm FromRange(DateTime startDate, DateTime endDate)
        {
            var startDateString = startDate.ToString("yyyy/MM/dd");
            var endDateString = endDate.ToString("yyyy/MM/dd");
            return new PublicationDateTerm(string.Format("{0}:{1}", startDateString, endDateString));
        }

        public static PublicationDateTerm FromDateTime(DateTime publicationDate)
        {
            var dateAsString = publicationDate.ToString("yy/MM/dd");
            return new PublicationDateTerm(dateAsString);
        }

        public override string ToString()
        {
            var stringDates = base.ToString().Replace("\"", "");
            return string.Format("({0})", stringDates);
        }
    }
}