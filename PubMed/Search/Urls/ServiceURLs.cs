﻿namespace PubMed.Search.Urls
{
    public static class ServiceURLs
    {
        public static string EInfoBaseURL
        {
            get { return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/einfo.fcgi"; }
        }

        public static string ESearchBaseURL
        {
            get { return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi"; }
        }

        public static string ESummaryBaseURL
        {
            get { return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/esummary.fcgi"; }
        }

        public static string EFetchBaseURL
        {
            get { return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi"; }
        }

        public static string ELinkBaseURL
        {
            get { return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/elink.fcgi"; }
        }
    }
}