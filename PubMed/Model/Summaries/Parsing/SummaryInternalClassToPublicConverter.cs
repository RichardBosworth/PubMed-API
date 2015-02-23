using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal class SummaryInternalClassToPublicConverter : ISummaryInternalClassToPublicConverter
    {
        public Summary Convert(eSummaryResult eSummaryResult)
        {
            // Generate the summary.
            Summary summary = new Summary();
            summary.ID = eSummaryResult.DocSum.Id.ToString();

            // Generate the neccesary components.
            ISummaryItemConverterFactory factory = new ConcreteSummaryItemConverterFactory();

            // Navigate through the xml summary list and convert it to the public summary.
            var items = eSummaryResult.DocSum.Item;
            foreach (var item in items)
            {
                ISummaryValueConverter valueConverter = factory.GetAppropriateConverter(item);
                if (valueConverter != null) valueConverter.AddItemToSummary(item, ref summary);
            }

            // Return the generated summary.
            return summary;
        }
    }
}