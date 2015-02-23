using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal class DateSummaryValueConverter : BaseSimpleSummaryValueConverter
    {
        protected override object GetObjectValue(string text)
        {
            return ConvertTextToDateTime(text);
        }

        protected override object GetObjectViaListValue(eSummaryResultDocSumItem item)
        {
            throw new NotImplementedException();
        }

        private DateTime? ConvertTextToDateTime(string text)
        {
            DateTime time;
            var parsedSuccessfully = DateTime.TryParse(text, out time);
            if (parsedSuccessfully)
            {
                return time;
            }

            return null;
        }
    }
}