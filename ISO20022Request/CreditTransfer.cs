using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParticipantServer.ISO20022Request.CreditTransfer
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09", IsNullable = false)]
    public partial class Document
    {

        private DocumentFIToFICstmrCdtTrf fIToFICstmrCdtTrfField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrf FIToFICstmrCdtTrf
        {
            get
            {
                return this.fIToFICstmrCdtTrfField;
            }
            set
            {
                this.fIToFICstmrCdtTrfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrf
    {

        private DocumentFIToFICstmrCdtTrfGrpHdr grpHdrField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInf cdtTrfTxInfField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdr GrpHdr
        {
            get
            {
                return this.grpHdrField;
            }
            set
            {
                this.grpHdrField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInf CdtTrfTxInf
        {
            get
            {
                return this.cdtTrfTxInfField;
            }
            set
            {
                this.cdtTrfTxInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdr
    {

        private string msgIdField;

        private string creDtTmField;

        private string nbOfTxsField;

        private DocumentFIToFICstmrCdtTrfGrpHdrSttlmInf sttlmInfField;

        private DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInf pmtTpInfField;

        private DocumentFIToFICstmrCdtTrfGrpHdrInstgAgt instgAgtField;

        private DocumentFIToFICstmrCdtTrfGrpHdrInstdAgt instdAgtField;

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
        public string NbOfTxs
        {
            get
            {
                return this.nbOfTxsField;
            }
            set
            {
                this.nbOfTxsField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrSttlmInf SttlmInf
        {
            get
            {
                return this.sttlmInfField;
            }
            set
            {
                this.sttlmInfField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInf PmtTpInf
        {
            get
            {
                return this.pmtTpInfField;
            }
            set
            {
                this.pmtTpInfField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrInstgAgt InstgAgt
        {
            get
            {
                return this.instgAgtField;
            }
            set
            {
                this.instgAgtField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrInstdAgt InstdAgt
        {
            get
            {
                return this.instdAgtField;
            }
            set
            {
                this.instdAgtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrSttlmInf
    {

        private string sttlmMtdField;

        private DocumentFIToFICstmrCdtTrfGrpHdrSttlmInfClrSys clrSysField;

        /// <remarks/>
        public string SttlmMtd
        {
            get
            {
                return this.sttlmMtdField;
            }
            set
            {
                this.sttlmMtdField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrSttlmInfClrSys ClrSys
        {
            get
            {
                return this.clrSysField;
            }
            set
            {
                this.clrSysField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrSttlmInfClrSys
    {

        private string prtryField;

        /// <remarks/>
        public string Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInf
    {

        private DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfSvcLvl svcLvlField;

        private DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfLclInstrm lclInstrmField;

        private DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfCtgyPurp ctgyPurpField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfSvcLvl SvcLvl
        {
            get
            {
                return this.svcLvlField;
            }
            set
            {
                this.svcLvlField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfLclInstrm LclInstrm
        {
            get
            {
                return this.lclInstrmField;
            }
            set
            {
                this.lclInstrmField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfCtgyPurp CtgyPurp
        {
            get
            {
                return this.ctgyPurpField;
            }
            set
            {
                this.ctgyPurpField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfSvcLvl
    {

        private string prtryField;

        /// <remarks/>
        public string Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfLclInstrm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfCtgyPurp
    {

        private string prtryField;

        /// <remarks/>
        public string Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrInstgAgt
    {

        private DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnId
    {

        private DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrInstdAgt
    {

        private DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnId
    {

        private DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInf
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfPmtId pmtIdField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfIntrBkSttlmAmt intrBkSttlmAmtField;

        private string accptncDtTmField;

        private string chrgBrField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfMndtRltdInf mndtRltdInfField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtr ultmtDbtrField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPty initgPtyField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtr dbtrField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcct dbtrAcctField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgt dbtrAgtField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgt cdtrAgtField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtr cdtrField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcct cdtrAcctField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtr ultmtCdtrField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfPurp purpField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInf rmtInfField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfPmtId PmtId
        {
            get
            {
                return this.pmtIdField;
            }
            set
            {
                this.pmtIdField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfIntrBkSttlmAmt IntrBkSttlmAmt
        {
            get
            {
                return this.intrBkSttlmAmtField;
            }
            set
            {
                this.intrBkSttlmAmtField = value;
            }
        }

        /// <remarks/>
        public string AccptncDtTm
        {
            get
            {
                return this.accptncDtTmField;
            }
            set
            {
                this.accptncDtTmField = value;
            }
        }

        /// <remarks/>
        public string ChrgBr
        {
            get
            {
                return this.chrgBrField;
            }
            set
            {
                this.chrgBrField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfMndtRltdInf MndtRltdInf
        {
            get
            {
                return this.mndtRltdInfField;
            }
            set
            {
                this.mndtRltdInfField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtr UltmtDbtr
        {
            get
            {
                return this.ultmtDbtrField;
            }
            set
            {
                this.ultmtDbtrField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPty InitgPty
        {
            get
            {
                return this.initgPtyField;
            }
            set
            {
                this.initgPtyField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtr Dbtr
        {
            get
            {
                return this.dbtrField;
            }
            set
            {
                this.dbtrField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcct DbtrAcct
        {
            get
            {
                return this.dbtrAcctField;
            }
            set
            {
                this.dbtrAcctField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgt DbtrAgt
        {
            get
            {
                return this.dbtrAgtField;
            }
            set
            {
                this.dbtrAgtField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgt CdtrAgt
        {
            get
            {
                return this.cdtrAgtField;
            }
            set
            {
                this.cdtrAgtField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtr Cdtr
        {
            get
            {
                return this.cdtrField;
            }
            set
            {
                this.cdtrField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcct CdtrAcct
        {
            get
            {
                return this.cdtrAcctField;
            }
            set
            {
                this.cdtrAcctField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtr UltmtCdtr
        {
            get
            {
                return this.ultmtCdtrField;
            }
            set
            {
                this.ultmtCdtrField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfPurp Purp
        {
            get
            {
                return this.purpField;
            }
            set
            {
                this.purpField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInf RmtInf
        {
            get
            {
                return this.rmtInfField;
            }
            set
            {
                this.rmtInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfPmtId
    {

        private string endToEndIdField;

        /// <remarks/>
        public string EndToEndId
        {
            get
            {
                return this.endToEndIdField;
            }
            set
            {
                this.endToEndIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfIntrBkSttlmAmt
    {

        private string ccyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfMndtRltdInf
    {

        private string mndtIdField;

        /// <remarks/>
        public string MndtId
        {
            get
            {
                return this.mndtIdField;
            }
            set
            {
                this.mndtIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtr
    {

        private string nmField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrID idField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrCtctDtls ctctDtlsField;

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

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrID Id
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
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrCtctDtls CtctDtls
        {
            get
            {
                return this.ctctDtlsField;
            }
            set
            {
                this.ctctDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrID
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrIDOrgId OrgId
        {
            get
            {
                return this.orgIdField;
            }
            set
            {
                this.orgIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrIDOrgId
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtDbtrCtctDtls
    {

        private string phneNbField;

        /// <remarks/>
        public string PhneNb
        {
            get
            {
                return this.phneNbField;
            }
            set
            {
                this.phneNbField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPty
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyID idField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyID
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyIDOrgId OrgId
        {
            get
            {
                return this.orgIdField;
            }
            set
            {
                this.orgIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyIDOrgId
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfInitgPtyIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtr
    {

        private string nmField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrID idField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrCtctDtls ctctDtlsField;

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

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrID Id
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
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrCtctDtls CtctDtls
        {
            get
            {
                return this.ctctDtlsField;
            }
            set
            {
                this.ctctDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrID
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrIDOrgId OrgId
        {
            get
            {
                return this.orgIdField;
            }
            set
            {
                this.orgIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrIDOrgId
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrCtctDtls
    {

        private string phneNbField;

        /// <remarks/>
        public string PhneNb
        {
            get
            {
                return this.phneNbField;
            }
            set
            {
                this.phneNbField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcct
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctID idField;

        private string nmField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctID
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctIDOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctIDOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctIDOthr
    {

        private string idField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctIDOthrSchmeNm schmeNmField;

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
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctIDOthrSchmeNm SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctIDOthrSchmeNm
    {

        private string prtryField;

        /// <remarks/>
        public string Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgt
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnId
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgt
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnId
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtr
    {

        private string nmField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrID idField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrCtctDtls ctctDtlsField;

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

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrID Id
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
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrCtctDtls CtctDtls
        {
            get
            {
                return this.ctctDtlsField;
            }
            set
            {
                this.ctctDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrID
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrIDOrgId OrgId
        {
            get
            {
                return this.orgIdField;
            }
            set
            {
                this.orgIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrIDOrgId
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrCtctDtls
    {

        private string phneNbField;

        /// <remarks/>
        public string PhneNb
        {
            get
            {
                return this.phneNbField;
            }
            set
            {
                this.phneNbField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcct
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctID idField;

        private string nmField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctID
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctIDOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctIDOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctIDOthr
    {

        private string idField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctIDOthrSchmeNm schmeNmField;

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
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctIDOthrSchmeNm SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctIDOthrSchmeNm
    {

        private string prtryField;

        /// <remarks/>
        public string Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtr
    {

        private string nmField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrID idField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrCtctDtls ctctDtlsField;

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

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrID Id
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
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrCtctDtls CtctDtls
        {
            get
            {
                return this.ctctDtlsField;
            }
            set
            {
                this.ctctDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrID
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrIDOrgId OrgId
        {
            get
            {
                return this.orgIdField;
            }
            set
            {
                this.orgIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrIDOrgId
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfUltmtCdtrCtctDtls
    {

        private string phneNbField;

        /// <remarks/>
        public string PhneNb
        {
            get
            {
                return this.phneNbField;
            }
            set
            {
                this.phneNbField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfPurp
    {

        private string prtryField;

        /// <remarks/>
        public string Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInf
    {

        private string ustrdField;

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInfStrd strdField;

        /// <remarks/>
        public string Ustrd
        {
            get
            {
                return this.ustrdField;
            }
            set
            {
                this.ustrdField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInfStrd Strd
        {
            get
            {
                return this.strdField;
            }
            set
            {
                this.strdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInfStrd
    {

        private DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInfStrdCdtrRefInf cdtrRefInfField;

        /// <remarks/>
        public DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInfStrdCdtrRefInf CdtrRefInf
        {
            get
            {
                return this.cdtrRefInfField;
            }
            set
            {
                this.cdtrRefInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09")]
    public partial class DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInfStrdCdtrRefInf
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


}
