using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal interface ISummaryValueConverter
    {
        void AddItemToSummary(eSummaryResultDocSumItem item, ref Summary summary);
    }
}