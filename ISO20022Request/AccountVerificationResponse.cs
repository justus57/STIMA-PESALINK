using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPSs.ISO20022Request.AccountVerificationresponses
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

        private string creDtTmField;

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

        private string creDtTmField;

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

        private DocumentIdVrfctnRptRptRsn rsnField;

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
        public DocumentIdVrfctnRptRptRsn Rsn
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
    public partial class DocumentIdVrfctnRptRptRsn
    {

        private string cdField;

        /// <remarks/>
        public string Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
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


}
