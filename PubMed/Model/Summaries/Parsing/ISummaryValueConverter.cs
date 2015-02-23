using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    public interface ISummaryValueConverter
    {
        void AddItemToSummary(eSummaryResultDocSumItem item, ref Summary summary);
    }
}