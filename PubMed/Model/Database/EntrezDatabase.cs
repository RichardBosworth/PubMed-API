using System;

namespace PubMed.Model.Database
{
    public class EntrezDatabase
    {
        public EntrezDatabase(string validEntrezName)
        {
            ValidEntrezName = validEntrezName;
        }

        /// <summary>
        ///     Gets the valid Entrez name for this database. This name can be used when searching the databases.
        /// </summary>
        public string ValidEntrezName { get; private set; }

        /// <summary>
        /// Gets the description of the database.
        /// </summary>
        public string DatabaseDescription { get; internal set; }

        /// <summary>
        /// Gets the date and time that the database was last updated.
        /// </summary>
        public DateTime LastUpdate { get; internal set; }

        public override string ToString()
        {
            return string.Format("{0}", ValidEntrezName);
        }
    }
}