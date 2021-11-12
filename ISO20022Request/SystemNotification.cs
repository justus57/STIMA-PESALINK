using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParticipantServer.ISO20022Request.SystemNotification
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.02", IsNullable = false)]
    public partial class Document
    {

        private DocumentSysEvtNtfctn sysEvtNtfctnField;

        /// <remarks/>
        public DocumentSysEvtNtfctn SysEvtNtfctn
        {
            get
            {
                return this.sysEvtNtfctnField;
            }
            set
            {
                this.sysEvtNtfctnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.02")]
    public partial class DocumentSysEvtNtfctn
    {

        private DocumentSysEvtNtfctnEvtInf evtInfField;

        /// <remarks/>
        public DocumentSysEvtNtfctnEvtInf EvtInf
        {
            get
            {
                return this.evtInfField;
            }
            set
            {
                this.evtInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.02")]
    public partial class DocumentSysEvtNtfctnEvtInf
    {

        private string evtCdField;

        private string evtParamField;

        private string evtDescField;

        private string evtTmField;

        /// <remarks/>
        public string EvtCd
        {
            get
            {
                return this.evtCdField;
            }
            set
            {
                this.evtCdField = value;
            }
        }

        /// <remarks/>
        public string EvtParam
        {
            get
            {
                return this.evtParamField;
            }
            set
            {
                this.evtParamField = value;
            }
        }

        /// <remarks/>
        public string EvtDesc
        {
            get
            {
                return this.evtDescField;
            }
            set
            {
                this.evtDescField = value;
            }
        }

        /// <remarks/>
        public string EvtTm
        {
            get
            {
                return this.evtTmField;
            }
            set
            {
                this.evtTmField = value;
            }
        }
    }


}