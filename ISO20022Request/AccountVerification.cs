using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParticipantServer.ISO20022Request.AccountVerification
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02", IsNullable = false)]
    public partial class Document
    {

        private DocumentIdVrfctnReq idVrfctnReqField;

        /// <remarks/>
        public DocumentIdVrfctnReq IdVrfctnReq
        {
            get
            {
                return this.idVrfctnReqField;
            }
            set
            {
                this.idVrfctnReqField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReq
    {

        private DocumentIdVrfctnReqAssgnmt assgnmtField;

        private DocumentIdVrfctnReqVrfctn vrfctnField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmt Assgnmt
        {
            get
            {
                return this.assgnmtField;
            }
            set
            {
                this.assgnmtField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnReqVrfctn Vrfctn
        {
            get
            {
                return this.vrfctnField;
            }
            set
            {
                this.vrfctnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmt
    {

        private string msgIdField;

        private string creDtTmField;

        private DocumentIdVrfctnReqAssgnmtFrstAgt frstAgtField;

        private DocumentIdVrfctnReqAssgnmtAssgnr assgnrField;

        private DocumentIdVrfctnReqAssgnmtAssgne assgneField;

        /// <remarks/>
        public string MsgId
        {
            get
            {
                return this.msgIdField;
            }
            set
            {
                this.msgIdField = value;
            }
        }

        /// <remarks/>
        public string CreDtTm
        {
            get
            {
                return this.creDtTmField;
            }
            set
            {
                this.creDtTmField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtFrstAgt FrstAgt
        {
            get
            {
                return this.frstAgtField;
            }
            set
            {
                this.frstAgtField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgnr Assgnr
        {
            get
            {
                return this.assgnrField;
            }
            set
            {
                this.assgnrField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgne Assgne
        {
            get
            {
                return this.assgneField;
            }
            set
            {
                this.assgneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtFrstAgt
    {

        private DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnId FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnId
    {

        private DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnIdOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnIdOthr
    {

        private string idField;

        /// <remarks/>
        public string Id
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgnr
    {

        private DocumentIdVrfctnReqAssgnmtAssgnrAgt agtField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgnrAgt Agt
        {
            get
            {
                return this.agtField;
            }
            set
            {
                this.agtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgnrAgt
    {

        private DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnId FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnId
    {

        private DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnIdOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnIdOthr
    {

        private string idField;

        /// <remarks/>
        public string Id
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgne
    {

        private DocumentIdVrfctnReqAssgnmtAssgneAgt agtField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgneAgt Agt
        {
            get
            {
                return this.agtField;
            }
            set
            {
                this.agtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgneAgt
    {

        private DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnId FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnId
    {

        private DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnIdOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnIdOthr
    {

        private string idField;

        /// <remarks/>
        public string Id
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqVrfctn
    {

        private string idField;

        private DocumentIdVrfctnReqVrfctnPtyAndAcctId ptyAndAcctIdField;

        /// <remarks/>
        public string Id
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
        public DocumentIdVrfctnReqVrfctnPtyAndAcctId PtyAndAcctId
        {
            get
            {
                return this.ptyAndAcctIdField;
            }
            set
            {
                this.ptyAndAcctIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqVrfctnPtyAndAcctId
    {

        private DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcct acctField;

        private DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgt agtField;

        /// <remarks/>
        public DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcct Acct
        {
            get
            {
                return this.acctField;
            }
            set
            {
                this.acctField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgt Agt
        {
            get
            {
                return this.agtField;
            }
            set
            {
                this.agtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcct
    {

        private DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcctOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcctOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcctOthr
    {

        private string idField;

        /// <remarks/>
        public string Id
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgt
    {

        private DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnId FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnId
    {

        private DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnIdOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02")]
    public partial class DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnIdOthr
    {

        private string idField;

        /// <remarks/>
        public string Id
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
    }


}