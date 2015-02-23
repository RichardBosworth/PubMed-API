namespace PubMed.Model.Links.Internal
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class eLinkResult
    {

        private eLinkResultLinkSet linkSetField;

        /// <remarks/>
        public eLinkResultLinkSet LinkSet
        {
            get
            {
                return this.linkSetField;
            }
            set
            {
                this.linkSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eLinkResultLinkSet
    {

        private string dbFromField;

        private eLinkResultLinkSetIdUrlSet[] idUrlListField;

        /// <remarks/>
        public string DbFrom
        {
            get
            {
                return this.dbFromField;
            }
            set
            {
                this.dbFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("IdUrlSet", IsNullable = false)]
        public eLinkResultLinkSetIdUrlSet[] IdUrlList
        {
            get
            {
                return this.idUrlListField;
            }
            set
            {
                this.idUrlListField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eLinkResultLinkSetIdUrlSet
    {

        private uint idField;

        private eLinkResultLinkSetIdUrlSetObjUrl objUrlField;

        /// <remarks/>
        public uint Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public eLinkResultLinkSetIdUrlSetObjUrl ObjUrl
        {
            get
            {
                return this.objUrlField;
            }
            set
            {
                this.objUrlField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eLinkResultLinkSetIdUrlSetObjUrl
    {

        private string urlField;

        private eLinkResultLinkSetIdUrlSetObjUrlIconUrl iconUrlField;

        private string subjectTypeField;

        private string categoryField;

        private string[] attributeField;

        private eLinkResultLinkSetIdUrlSetObjUrlProvider providerField;

        /// <remarks/>
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public eLinkResultLinkSetIdUrlSetObjUrlIconUrl IconUrl
        {
            get
            {
                return this.iconUrlField;
            }
            set
            {
                this.iconUrlField = value;
            }
        }

        /// <remarks/>
        public string SubjectType
        {
            get
            {
                return this.subjectTypeField;
            }
            set
            {
                this.subjectTypeField = value;
            }
        }

        /// <remarks/>
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public string[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        public eLinkResultLinkSetIdUrlSetObjUrlProvider Provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eLinkResultLinkSetIdUrlSetObjUrlIconUrl
    {

        private string lNGField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LNG
        {
            get
            {
                return this.lNGField;
            }
            set
            {
                this.lNGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eLinkResultLinkSetIdUrlSetObjUrlProvider
    {

        private string nameField;

        private string nameAbbrField;

        private ushort idField;

        private eLinkResultLinkSetIdUrlSetObjUrlProviderUrl urlField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string NameAbbr
        {
            get
            {
                return this.nameAbbrField;
            }
            set
            {
                this.nameAbbrField = value;
            }
        }

        /// <remarks/>
        public ushort Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public eLinkResultLinkSetIdUrlSetObjUrlProviderUrl Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class eLinkResultLinkSetIdUrlSetObjUrlProviderUrl
    {

        private string lNGField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LNG
        {
            get
            {
                return this.lNGField;
            }
            set
            {
                this.lNGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}