using System;
using System.Collections.Generic;
using System.Text;

namespace ISO20022Requests.PaymentStatusReport.Response
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11", IsNullable = false)]
    public partial class Document
    {

        private DocumentFIToFIPmtStsRpt fIToFIPmtStsRptField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRpt FIToFIPmtStsRpt
        {
            get
            {
                return this.fIToFIPmtStsRptField;
            }
            set
            {
                this.fIToFIPmtStsRptField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRpt
    {

        private DocumentFIToFIPmtStsRptGrpHdr grpHdrField;

        private DocumentFIToFIPmtStsRptOrgnlGrpInfAndSts orgnlGrpInfAndStsField;

        private DocumentFIToFIPmtStsRptTxInfAndSts txInfAndStsField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptGrpHdr GrpHdr
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
        public DocumentFIToFIPmtStsRptOrgnlGrpInfAndSts OrgnlGrpInfAndSts
        {
            get
            {
                return this.orgnlGrpInfAndStsField;
            }
            set
            {
                this.orgnlGrpInfAndStsField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndSts TxInfAndSts
        {
            get
            {
                return this.txInfAndStsField;
            }
            set
            {
                this.txInfAndStsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptGrpHdr
    {

        private string msgIdField;

        private System.DateTime creDtTmField;

        private DocumentFIToFIPmtStsRptGrpHdrInstgAgt instgAgtField;

        private DocumentFIToFIPmtStsRptGrpHdrInstdAgt instdAgtField;

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
        public DocumentFIToFIPmtStsRptGrpHdrInstgAgt InstgAgt
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
        public DocumentFIToFIPmtStsRptGrpHdrInstdAgt InstdAgt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptGrpHdrInstgAgt
    {

        private DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnId
    {

        private DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptGrpHdrInstdAgt
    {

        private DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnId
    {

        private DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptOrgnlGrpInfAndSts
    {

        private string orgnlMsgIdField;

        private string orgnlMsgNmIdField;

        private System.DateTime orgnlCreDtTmField;

        /// <remarks/>
        public string OrgnlMsgId
        {
            get
            {
                return this.orgnlMsgIdField;
            }
            set
            {
                this.orgnlMsgIdField = value;
            }
        }

        /// <remarks/>
        public string OrgnlMsgNmId
        {
            get
            {
                return this.orgnlMsgNmIdField;
            }
            set
            {
                this.orgnlMsgNmIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime OrgnlCreDtTm
        {
            get
            {
                return this.orgnlCreDtTmField;
            }
            set
            {
                this.orgnlCreDtTmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndSts
    {

        private string stsIdField;

        private string orgnlEndToEndIdField;

        private string txStsField;

        private DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInf stsRsnInfField;

        private System.DateTime accptncDtTmField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRef orgnlTxRefField;

        /// <remarks/>
        public string StsId
        {
            get
            {
                return this.stsIdField;
            }
            set
            {
                this.stsIdField = value;
            }
        }

        /// <remarks/>
        public string OrgnlEndToEndId
        {
            get
            {
                return this.orgnlEndToEndIdField;
            }
            set
            {
                this.orgnlEndToEndIdField = value;
            }
        }

        /// <remarks/>
        public string TxSts
        {
            get
            {
                return this.txStsField;
            }
            set
            {
                this.txStsField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInf StsRsnInf
        {
            get
            {
                return this.stsRsnInfField;
            }
            set
            {
                this.stsRsnInfField = value;
            }
        }

        /// <remarks/>
        public System.DateTime AccptncDtTm
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRef OrgnlTxRef
        {
            get
            {
                return this.orgnlTxRefField;
            }
            set
            {
                this.orgnlTxRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInf
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtr orgtrField;

        private DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfRsn rsnField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtr Orgtr
        {
            get
            {
                return this.orgtrField;
            }
            set
            {
                this.orgtrField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfRsn Rsn
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtr
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrID idField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrID
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgId OrgId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgId
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfRsn
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRef
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefIntrBkSttlmAmt intrBkSttlmAmtField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefReqdExctnDt reqdExctnDtField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInf sttlmInfField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInf pmtTpInfField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInf rmtInfField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtr dbtrField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcct dbtrAcctField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgt dbtrAgtField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgt cdtrAgtField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtr cdtrField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcct cdtrAcctField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPurp purpField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefIntrBkSttlmAmt IntrBkSttlmAmt
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefReqdExctnDt ReqdExctnDt
        {
            get
            {
                return this.reqdExctnDtField;
            }
            set
            {
                this.reqdExctnDtField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInf SttlmInf
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInf PmtTpInf
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInf RmtInf
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

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtr Dbtr
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcct DbtrAcct
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgt DbtrAgt
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgt CdtrAgt
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtr Cdtr
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcct CdtrAcct
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPurp Purp
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefIntrBkSttlmAmt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefReqdExctnDt
    {

        private System.DateTime dtTmField;

        /// <remarks/>
        public System.DateTime DtTm
        {
            get
            {
                return this.dtTmField;
            }
            set
            {
                this.dtTmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInf
    {

        private string sttlmMtdField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInfClrSys clrSysField;

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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInfClrSys ClrSys
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInfClrSys
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInf
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfSvcLvl svcLvlField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfLclInstrm lclInstrmField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfCtgyPurp ctgyPurpField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfSvcLvl SvcLvl
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfLclInstrm LclInstrm
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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfCtgyPurp CtgyPurp
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfSvcLvl
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfLclInstrm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfCtgyPurp
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInf
    {

        private string ustrdField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtr
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPty ptyField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPty Pty
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPty
    {

        private string nmField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyCtctDtls ctctDtlsField;

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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyCtctDtls CtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyCtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcct
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctID idField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctID
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgt
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnId
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgt
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnId
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtr
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPty ptyField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPty Pty
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPty
    {

        private string nmField;

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyCtctDtls ctctDtlsField;

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
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyCtctDtls CtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyCtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcct
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctID idField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctID
    {

        private DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11")]
    public partial class DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPurp
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


}

