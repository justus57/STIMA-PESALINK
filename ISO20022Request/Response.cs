using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISO20022Requests.AccountVerification.Response
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02", IsNullable = false)]
    public partial class Document
    {

        private DocumentIdVrfctnRpt idVrfctnRptField;

        private Signature signatureField;

        /// <remarks/>
        public DocumentIdVrfctnRpt IdVrfctnRpt
        {
            get
            {
                return this.idVrfctnRptField;
            }
            set
            {
                this.idVrfctnRptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRpt
    {

        private DocumentIdVrfctnRptAssgnmt assgnmtField;

        private DocumentIdVrfctnRptOrgnlAssgnmt orgnlAssgnmtField;

        private DocumentIdVrfctnRptRpt rptField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmt Assgnmt
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
        public DocumentIdVrfctnRptOrgnlAssgnmt OrgnlAssgnmt
        {
            get
            {
                return this.orgnlAssgnmtField;
            }
            set
            {
                this.orgnlAssgnmtField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnRptRpt Rpt
        {
            get
            {
                return this.rptField;
            }
            set
            {
                this.rptField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmt
    {

        private string msgIdField;

        private System.DateTime creDtTmField;

        private DocumentIdVrfctnRptAssgnmtFrstAgt frstAgtField;

        private DocumentIdVrfctnRptAssgnmtAssgnr assgnrField;

        private DocumentIdVrfctnRptAssgnmtAssgne assgneField;

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
        public System.DateTime CreDtTm
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
        public DocumentIdVrfctnRptAssgnmtFrstAgt FrstAgt
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
        public DocumentIdVrfctnRptAssgnmtAssgnr Assgnr
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
        public DocumentIdVrfctnRptAssgnmtAssgne Assgne
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtFrstAgt
    {

        private DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnId
    {

        private DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgnr
    {

        private DocumentIdVrfctnRptAssgnmtAssgnrAgt agtField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtAssgnrAgt Agt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgnrAgt
    {

        private DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnId
    {

        private DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgne
    {

        private DocumentIdVrfctnRptAssgnmtAssgneAgt agtField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtAssgneAgt Agt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgneAgt
    {

        private DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnId
    {

        private DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptOrgnlAssgnmt
    {

        private string msgIdField;

        private System.DateTime creDtTmField;

        private DocumentIdVrfctnRptOrgnlAssgnmtFrstAgt frstAgtField;

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
        public System.DateTime CreDtTm
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
        public DocumentIdVrfctnRptOrgnlAssgnmtFrstAgt FrstAgt
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptOrgnlAssgnmtFrstAgt
    {

        private DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnId
    {

        private DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRpt
    {

        private string orgnlIdField;

        private bool vrfctnField;

        private DocumentIdVrfctnRptRptOrgnlPtyAndAcctId orgnlPtyAndAcctIdField;

        private DocumentIdVrfctnRptRptUpdtdPtyAndAcctId updtdPtyAndAcctIdField;

        /// <remarks/>
        public string OrgnlId
        {
            get
            {
                return this.orgnlIdField;
            }
            set
            {
                this.orgnlIdField = value;
            }
        }

        /// <remarks/>
        public bool Vrfctn
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

        /// <remarks/>
        public DocumentIdVrfctnRptRptOrgnlPtyAndAcctId OrgnlPtyAndAcctId
        {
            get
            {
                return this.orgnlPtyAndAcctIdField;
            }
            set
            {
                this.orgnlPtyAndAcctIdField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnRptRptUpdtdPtyAndAcctId UpdtdPtyAndAcctId
        {
            get
            {
                return this.updtdPtyAndAcctIdField;
            }
            set
            {
                this.updtdPtyAndAcctIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptOrgnlPtyAndAcctId
    {

        private DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcct acctField;

        private DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgt agtField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcct Acct
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
        public DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgt Agt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcct
    {

        private DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcctOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcctOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcctOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgt
    {

        private DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnId
    {

        private DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptUpdtdPtyAndAcctId
    {

        private DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdPty ptyField;

        private DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcct acctField;

        private DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgt agtField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdPty Pty
        {
            get
            {
                return this.ptyField;
            }
            set
            {
                this.ptyField = value;
            }
        }

        /// <remarks/>
        public DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcct Acct
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
        public DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgt Agt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdPty
    {

        private string nmField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcct
    {

        private DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcctOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcctOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcctOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgt
    {

        private DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnId
    {

        private DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02")]
    public partial class DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class Signature
    {

        private SignatureSignedInfo signedInfoField;

        private string signatureValueField;

        private SignatureKeyInfo keyInfoField;

        private string idField;

        /// <remarks/>
        public SignatureSignedInfo SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public string SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public SignatureKeyInfo KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfo
    {

        private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

        private SignatureSignedInfoSignatureMethod signatureMethodField;

        private SignatureSignedInfoReference[] referenceField;

        /// <remarks/>
        public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public SignatureSignedInfoReference[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoCanonicalizationMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoSignatureMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReference
    {

        private SignatureSignedInfoReferenceTransform[] transformsField;

        private SignatureSignedInfoReferenceDigestMethod digestMethodField;

        private string digestValueField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public SignatureSignedInfoReferenceTransform[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoReferenceDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceTransform
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceDigestMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfo
    {

        private SignatureKeyInfoX509Data x509DataField;

        private string idField;

        /// <remarks/>
        public SignatureKeyInfoX509Data X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoX509Data
    {

        private string x509CertificateField;

        /// <remarks/>
        public string X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }


}
