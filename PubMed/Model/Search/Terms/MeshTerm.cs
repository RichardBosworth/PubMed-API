namespace PubMed.Model.Search.Terms
{
    /// <summary>
    ///     <para>
    ///         The NLM Medical Subject Headings controlled vocabulary of biomedical terms that is used to describe the
    ///         subject of each journal article in MEDLINE. MeSH contains approximately 26 thousand terms and is updated
    ///         annually to reflect changes in medicine and medical terminology. MeSH terms are arranged hierarchically by
    ///         subject categories with more specific terms arranged beneath broader terms. PubMed allows you to view this
    ///         hierarchy and select terms for searching in the MeSH Database.
    ///     </para>
    ///     <para>
    ///         Skilled subject analysts examine journal articles and assign to each the most specific MeSH terms applicable
    ///         - typically ten to twelve. Applying the MeSH vocabulary ensures that articles are uniformly indexed by subject,
    ///         whatever the author's words.
    ///     </para>
    ///     <para>Notes on MeSH Terms and Major MeSH Topic search fields:</para>
    ///     <list type="bullet">
    ///         <item>
    ///             To search the term only as a MeSH term, it must be tagged using the search field, e.g., [mh] for MeSH
    ///             Terms or [majr] for MeSH Major Topic. A tagged term is checked against the MeSH translation table, and then
    ///             mapped to the appropriate MeSH term(s). To turn off mapping to multiple MeSH terms, enter the tagged MeSH
    ///             term in double quotes
    ///         </item>
    ///         <item>
    ///             MeSH terms are arranged hierarchically by subject categories with more specific terms arranged beneath
    ///             broader terms. MeSH terms in PubMed automatically include the more specific MeSH terms in a search. To turn
    ///             off this automatic feature, use the search syntax [mh:noexp], e.g., neoplasms [mh:noexp].For more detailed
    ///             information about MeSH vocabulary including the hierarchical structure, please see the MeSH homepage.
    ///         </item>
    ///         <item>
    ///             MeSH/Subheading Combinations: To directly attach MeSH Subheadings, use the format MeSH Term/Subheading,
    ///             e.g., neoplasms/diet therapy. You may also use the two-letter MeSH Subheading abbreviations, e.g.,
    ///             neoplasms/dh. The [mh] tag is not required, however [majr] may be used, e.g., plants/genetics[majr]. Only
    ///             one Subheading may be directly attached to a MeSH term. For a MeSH/Subheading combination, PubMed always
    ///             includes the more specific terms arranged beneath broader terms for the MeSH term and also includes the
    ///             more specific terms arranged beneath broader Subheadings. The broader Subheading, or one of its
    ///             indentions’, will be directly attached to the MeSH term or one of its indentions’. For example,
    ///             hypertension/therapy also retrieves hypertension/diet therapy; hypertension/drug therapy; hypertension,
    ///             malignant/therapy; hypertension, malignant/drug therapy, and so on, as well as hypertension/therapy.
    ///         </item>
    ///         <item>
    ///             To turn off the automatic inclusion of the more specific terms, use the syntax [field:noexp], e.g.,
    ///             hypertension [mh:noexp], or hypertension [majr:noexp], or hypertension/therapy [mh:noexp]. The latter
    ///             example turns off the more specific terms in both parts, searching for only the one Subheading therapy
    ///             attached directly to only the one MeSH term hypertension.
    ///         </item>
    ///         <item>
    ///             If parentheses are embedded in a MeSH term, replace the parentheses with a space and tag with [mh] e.g.,
    ///             enter the MeSH term Benzo(a)pyrene as benzo a pyrene [mh].
    ///         </item>
    ///         <item>MeSH terms can be selected for searching in the MeSH database and from the advanced search builder index</item>
    ///     </list>
    /// </summary>
    public class MeshTerm : SearchTerm
    {
        public MeshTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "MESH Terms"; }
        }
    }
}