using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal interface ISummaryItemConverterFactory
    {
        ISummaryValueConverter GetAppropriateConverter(eSummaryResultDocSumItem item);
    }

    internal class ConcreteSummaryItemConverterFactory : ISummaryItemConverterFactory
    {
        public ISummaryValueConverter GetAppropriateConverter(eSummaryResultDocSumItem item)
        {
            // Check if it can be converted based on type.
            switch (item.Type.ToLower())
            {
                case "string":
                    return new StringSummaryValueConverter();
                case "date":
                    return new DateSummaryValueConverter();
                case "integer":
                    return new IntegerSummaryValueConverter();
                case "list":
                    return new ListSummaryValueConverter();
            }

            // Check for specific lists.
            if (item.Name == "AuthorList")
            {
                
            }

            return null;
        }
    }
}