using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    /// <summary>
    /// Provides functionality to convert the internal representation of a Summary to it's easy-use, publically available form.
    /// </summary>
    public interface ISummaryInternalClassToPublicConverter
    {
        Summary Convert(eSummaryResult eSummaryResult);
    }
}