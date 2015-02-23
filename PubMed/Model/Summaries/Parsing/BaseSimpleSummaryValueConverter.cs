using System;
using System.Linq;
using System.Reflection;
using System.Resources;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal abstract class BaseSimpleSummaryValueConverter : ISummaryValueConverter
    {
        public void AddItemToSummary(eSummaryResultDocSumItem item, ref Summary summary)
        {
            // Check if there is actually text.
            if (!IsListRoot(item))
            {
                if (item.Text == null)
                {
                    return;
                }
                if (String.IsNullOrEmpty(item.Text[0]))
                {
                    return;
                }
            }


            var properties = summary.GetType().GetRuntimeProperties();
            var propertyInfos = properties as PropertyInfo[] ?? properties.ToArray();
            if (propertyInfos.Any(Predicate(item)))
            {
                var propertyInfo = propertyInfos.Single(Predicate(item));

                if (IsListRoot(item))
                {
                    if (propertyInfo != null) propertyInfo.SetValue(summary, GetObjectViaListValue(item));
                }
                else
                {
                    if (propertyInfo != null) propertyInfo.SetValue(summary, GetObjectValue(item.Text[0]));
                }
            }
        }

        private bool IsListRoot(eSummaryResultDocSumItem item)
        {
            return item.Type.ToLower() == "list";
        }

        protected abstract object GetObjectValue(string text);
        protected abstract object GetObjectViaListValue(eSummaryResultDocSumItem item);

        private static Func<PropertyInfo, bool> Predicate(eSummaryResultDocSumItem item)
        {
            return info => String.Equals(info.Name, item.Name, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}