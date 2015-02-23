using System;
using System.Linq;
using System.Reflection;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal class IntegerSummaryValueConverter : BaseSimpleSummaryValueConverter
    {
        protected override object GetObjectValue(string text)
        {
            return Convert.ToInt32(text);
        }

        protected override object GetObjectViaListValue(eSummaryResultDocSumItem item)
        {
            throw new NotImplementedException();
        }
    }
}