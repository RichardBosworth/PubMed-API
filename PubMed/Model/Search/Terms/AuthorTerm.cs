namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     <para>
    ///         The format to search for this field is: last name followed by a space and up to the first two initials
    ///         followed by a space and a suffix abbreviation, if applicable, all without periods or a comma after the last
    ///         name (e.g., fauci as or o'brien jc jr). Initials and suffixes may be omitted when searching.
    ///     </para>
    ///     <para>
    ///         PubMed automatically truncates a search for an author's name to account for varying initials, e.g., o'brien j
    ///         [au] will retrieve o'brien ja, o'brien jb, o'brien jc jr, as well as o'brien j. To turn off automatic
    ///         truncation, enclose the author's name in double quotes and tag with [au] in brackets, e.g., "o'brien j" [au] to
    ///         retrieve just o'brien j.
    ///     </para>
    ///     <para>
    ///         Searching by full author name for articles published from 2002 forward is also possible, if available. Full
    ///         names display in the FAU field on the MEDLINE display format. Various limits on the number of authors included
    ///         in the MEDLINE citation have existed over the years (see NLM policy on author names).
    ///     </para>
    /// </summary>
    public class AuthorTerm : SearchTerm
    {
        public AuthorTerm(string term) : base(term)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="firstInitials">OPTIONAL: Up to the first two initials of the author's name.</param>
        /// <param name="lastname">The last name of the author.</param>
        public AuthorTerm(string lastname, string firstInitials = "") : base(GenerateCorrectNameFormat(lastname, firstInitials))
        {
        }

        protected override string SearchTagString
        {
            get { return "author"; }
        }

        private static string GenerateCorrectNameFormat(string lastname, string firstInitials)
        {
            string initials = firstInitials;
            if (initials.Length>2)
            {
                initials = firstInitials.Substring(0, 2);
            }
            var generateCorrectNameFormat = string.Format("{0} {1}", lastname, initials);
            return generateCorrectNameFormat;
        }
    }
}