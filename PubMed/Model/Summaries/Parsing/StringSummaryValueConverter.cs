using System;
using System.Linq;
using System.Reflection;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal class StringSummaryValueConverter : BaseSimpleSummaryValueConverter
    {
        protected override object GetObjectValue(string text)
        {
            return text;
        }

        protected override object GetObjectViaListValue(eSummaryResultDocSumItem item)
        {
            throw new NotImplementedException();
        }
    }
}