using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPSs.ISO20022Request.SystemNotificationresponse
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.011.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.011.001.01", IsNullable = false)]
    public partial class Document
    {

        private DocumentSysEvtAck sysEvtAckField;

        /// <remarks/>
        public DocumentSysEvtAck SysEvtAck
        {
            get
            {
                return this.sysEvtAckField;
            }
            set
            {
                this.sysEvtAckField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:admi.011.001.01")]
    public partial class DocumentSysEvtAck
    {

        private string msgIdField;

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
    }


}
