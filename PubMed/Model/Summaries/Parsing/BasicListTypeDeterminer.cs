using System;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal class BasicListTypeDeterminer : IListTypeDeterminer
    {
        public Type DetermineListType(eSummaryResultDocSumItem item)
        {
            switch (item.Item[0].Type.ToLower())
            {
                case "string":
                    return typeof (string);
                case "date":
                    return typeof (DateTime);
                case "integer":
                    return typeof (int);
            }

            return null;
        }
    }
}