using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParticipantServer.ISO20022Request.MessageReject
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01", IsNullable = false)]
    public partial class Document
    {

        private DocumentAdmi00200101 admi00200101Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("admi.002.001.01")]
        public DocumentAdmi00200101 admi00200101
        {
            get
            {
                return this.admi00200101Field;
            }
            set
            {
                this.admi00200101Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    public partial class DocumentAdmi00200101
    {

        private DocumentAdmi00200101RltdRef rltdRefField;

        private DocumentAdmi00200101Rsn rsnField;

        /// <remarks/>
        public DocumentAdmi00200101RltdRef RltdRef
        {
            get
            {
                return this.rltdRefField;
            }
            set
            {
                this.rltdRefField = value;
            }
        }

        /// <remarks/>
        public DocumentAdmi00200101Rsn Rsn
        {
            get
            {
                return this.rsnField;
            }
            set
            {
                this.rsnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    public partial class DocumentAdmi00200101RltdRef
    {

        private string refField;

        /// <remarks/>
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    public partial class DocumentAdmi00200101Rsn
    {

        private string rjctgPtyRsnField;

        private string rjctnDtTmField;

        private string rsnDescField;

        private string addtlDataField;

        /// <remarks/>
        public string RjctgPtyRsn
        {
            get
            {
                return this.rjctgPtyRsnField;
            }
            set
            {
                this.rjctgPtyRsnField = value;
            }
        }

        /// <remarks/>
        public string RjctnDtTm
        {
            get
            {
                return this.rjctnDtTmField;
            }
            set
            {
                this.rjctnDtTmField = value;
            }
        }

        /// <remarks/>
        public string RsnDesc
        {
            get
            {
                return this.rsnDescField;
            }
            set
            {
                this.rsnDescField = value;
            }
        }

        /// <remarks/>
        public string AddtlData
        {
            get
            {
                return this.addtlDataField;
            }
            set
            {
                this.addtlDataField = value;
            }
        }
    }


}
