using System;
using System.Collections;
using System.Collections.Generic;
using PubMed.Model.Summaries.Internal;

namespace PubMed.Model.Summaries.Parsing
{
    internal class ListSummaryValueConverter : BaseSimpleSummaryValueConverter
    {
        protected override object GetObjectValue(string text)
        {
            throw new NotImplementedException();
        }

        protected override object GetObjectViaListValue(eSummaryResultDocSumItem item)
        {
            // Determine if a custom list is needed.
            if (CustomListNeeded(item))
            {
                return DoCustomList(item);
            }

            IListTypeDeterminer listTypeDeterminer = new BasicListTypeDeterminer();
            Type listType = listTypeDeterminer.DetermineListType(item);

            // Generate a list of that type.
            var genericListType = typeof(List<>);
            var constructedListType = genericListType.MakeGenericType(listType);
            var instance = Activator.CreateInstance(constructedListType) as IList;

            // Add all the items of that type.
            foreach (var subItem in item.Item)
            {
                switch (listType.Name.ToLower())
                {
                    case "string":
                        instance.Add(subItem.Value);
                        break;
                    case "date":
                        instance.Add(ConvertTextToDateTime(subItem.Value));
                        break;
                    case "integer":
                        instance.Add(Convert.ToInt32(subItem.Value));
                        break;
                }
            }

            return instance;
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

        private object DoCustomList(eSummaryResultDocSumItem item)
        {
            IComplexListGenerator complexListGenerator = null;
            switch (item.Name.ToLower())
            {
                case "authorlist":
                    complexListGenerator = new AuthorsListGenerator();
                    break;
                case "articleids":
                    complexListGenerator = new ArticleIDsListGenerator();
                    break;
                case "history":
                    complexListGenerator = new HistoryListGenerator();
                    break;
            }

            if (complexListGenerator != null) return complexListGenerator.GenerateList(item);
            return null;
        }

        private bool CustomListNeeded(eSummaryResultDocSumItem item)
        {
            switch (item.Name.ToLower())
            {
                case "authorlist":
                    return true;
                case "articleids":
                    return true;
                case "history":
                    return true;
            }


            return false;
        }
    }
}