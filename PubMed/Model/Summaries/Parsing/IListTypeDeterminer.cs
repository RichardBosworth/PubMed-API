using System;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal interface IListTypeDeterminer
    {
        Type DetermineListType(eSummaryResultDocSumItem item);
    }
}