using System;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    public interface IListTypeDeterminer
    {
        Type DetermineListType(eSummaryResultDocSumItem item);
    }
}