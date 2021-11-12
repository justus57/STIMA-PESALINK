
namespace ParticipantServer.ISO20022Request.PaymentStatusRequest
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04", IsNullable = false)]
    public partial class Document
    {

        private DocumentFIToFIPmtStsReq fIToFIPmtStsReqField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReq FIToFIPmtStsReq
        {
            get
            {
                return this.fIToFIPmtStsReqField;
            }
            set
            {
                this.fIToFIPmtStsReqField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReq
    {

        private DocumentFIToFIPmtStsReqGrpHdr grpHdrField;

        private DocumentFIToFIPmtStsReqOrgnlGrpInf orgnlGrpInfField;

        private DocumentFIToFIPmtStsReqTxInf txInfField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqGrpHdr GrpHdr
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
        public DocumentFIToFIPmtStsReqOrgnlGrpInf OrgnlGrpInf
        {
            get
            {
                return this.orgnlGrpInfField;
            }
            set
            {
                this.orgnlGrpInfField = value;
            }
        }

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInf TxInf
        {
            get
            {
                return this.txInfField;
            }
            set
            {
                this.txInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqGrpHdr
    {

        private string msgIdField;

        private string creDtTmField;

        private DocumentFIToFIPmtStsReqGrpHdrInstgAgt instgAgtField;

        private DocumentFIToFIPmtStsReqGrpHdrInstdAgt instdAgtField;

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
        public DocumentFIToFIPmtStsReqGrpHdrInstgAgt InstgAgt
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
        public DocumentFIToFIPmtStsReqGrpHdrInstdAgt InstdAgt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqGrpHdrInstgAgt
    {

        private DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnId
    {

        private DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqGrpHdrInstdAgt
    {

        private DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnId
    {

        private DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqOrgnlGrpInf
    {

        private string orgnlMsgIdField;

        private string orgnlMsgNmIdField;

        private string orgnlCreDtTmField;

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
        public string OrgnlCreDtTm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInf
    {

        private string stsReqIdField;

        private string orgnlEndToEndIdField;

        private string accptncDtTmField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRef orgnlTxRefField;

        /// <remarks/>
        public string StsReqId
        {
            get
            {
                return this.stsReqIdField;
            }
            set
            {
                this.stsReqIdField = value;
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRef OrgnlTxRef
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRef
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefIntrBkSttlmAmt intrBkSttlmAmtField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefReqdExctnDt reqdExctnDtField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInf sttlmInfField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInf pmtTpInfField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInf mndtRltdInfField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInf rmtInfField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtr ultmtDbtrField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtr dbtrField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcct dbtrAcctField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgt dbtrAgtField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgt cdtrAgtField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtr cdtrField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcct cdtrAcctField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtr ultmtCdtrField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPurp purpField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefIntrBkSttlmAmt IntrBkSttlmAmt
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefReqdExctnDt ReqdExctnDt
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInf SttlmInf
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInf PmtTpInf
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInf MndtRltdInf
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInf RmtInf
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtr UltmtDbtr
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtr Dbtr
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcct DbtrAcct
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgt DbtrAgt
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgt CdtrAgt
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtr Cdtr
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcct CdtrAcct
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtr UltmtCdtr
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPurp Purp
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefIntrBkSttlmAmt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefReqdExctnDt
    {

        private string dtTmField;

        /// <remarks/>
        public string DtTm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInf
    {

        private string sttlmMtdField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInfClrSys clrSysField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInfClrSys ClrSys
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInfClrSys
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInf
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfSvcLvl svcLvlField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfLclInstrm lclInstrmField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfCtgyPurp ctgyPurpField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfSvcLvl SvcLvl
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfLclInstrm LclInstrm
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfCtgyPurp CtgyPurp
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfSvcLvl
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfLclInstrm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfCtgyPurp
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInf
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInfCdtTrfMndt cdtTrfMndtField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInfCdtTrfMndt CdtTrfMndt
        {
            get
            {
                return this.cdtTrfMndtField;
            }
            set
            {
                this.cdtTrfMndtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInfCdtTrfMndt
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInf
    {

        private string ustrdField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrd strdField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrd Strd
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrd
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrdCdtrRefInf cdtrRefInfField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrdCdtrRefInf CdtrRefInf
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrdCdtrRefInf
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtr
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPty ptyField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPty Pty
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPty
    {

        private string nmField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyID idField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyCtctDtls ctctDtlsField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyID Id
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyCtctDtls CtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyID
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgId OrgId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgId
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyCtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtr
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPty ptyField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPty Pty
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPty
    {

        private string nmField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyID idField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyCtctDtls ctctDtlsField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyID Id
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyCtctDtls CtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyID
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgId OrgId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgId
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyCtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcct
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctID idField;

        private string nmField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctID
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctIDOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctIDOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctIDOthr
    {

        private string idField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctIDOthrSchmeNm schmeNmField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctIDOthrSchmeNm SchmeNm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctIDOthrSchmeNm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgt
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnId
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgt
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnId finInstnIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnId FinInstnId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnId
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtr
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPty ptyField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPty Pty
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPty
    {

        private string nmField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyID idField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyCtctDtls ctctDtlsField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyID Id
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyCtctDtls CtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyID
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgId OrgId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgId
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyCtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcct
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctID idField;

        private string nmField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctID Id
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctID
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctIDOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctIDOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctIDOthr
    {

        private string idField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctIDOthrSchmeNm schmeNmField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctIDOthrSchmeNm SchmeNm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctIDOthrSchmeNm
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtr
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPty ptyField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPty Pty
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPty
    {

        private string nmField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyID idField;

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyCtctDtls ctctDtlsField;

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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyID Id
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
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyCtctDtls CtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyID
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgId orgIdField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgId OrgId
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgId
    {

        private DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgIdOthr Othr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgIdOthr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyCtctDtls
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04")]
    public partial class DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPurp
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