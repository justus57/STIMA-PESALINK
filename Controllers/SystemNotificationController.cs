using ISO20022Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Reflection;
using ParticipantServer.ISO20022Request.SystemNotification;
using System.Text;


namespace ParticipantServer.Controllers
{
    [ApiController]
    [Route("v1/system-event-notification")]
    [Consumes("application/xml")]


    public class SystemNotificationController : ControllerBase
    {

        public async Task SystemNotification()
        {
            try
            {
                string content = "";
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    content = await reader.ReadToEndAsync();
                }

                System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\Incomingxml\Systemnotification(IPS)\systemnotificationIso20022(IPS)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".XML", content);

                string response = null;
                string EventDesc = GenerateOrderLineTransactionNumber(Guid.NewGuid().ToString());
                string SystemNotificationEndpoint = "https://api.stage.pesalink.co.ke/iso20022/async/v1/system-event-notification";
                var xmlbody = new IPSs.ISO20022Request.SystemNotificationresponse.Document
                {
                    SysEvtAck = new IPSs.ISO20022Request.SystemNotificationresponse.DocumentSysEvtAck
                    {
                        MsgId = EventDesc
                    }

                };
                //Write XML to file
                string dest = "SystemNotification.xml";
                using (XmlWriter xmlWriter = XmlWriter.Create(dest))
                {

                    XmlSerializer s = new XmlSerializer(xmlbody.GetType());
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    ns.Add("", "");
                    s.Serialize(xmlWriter, xmlbody, ns);

                }                
                //Send Request to IPS

                XmlDocument doc = new XmlDocument();
                XmlSerializer ser = new XmlSerializer(xmlbody.GetType(), "");
                using (MemoryStream memStm = new MemoryStream())
                {
                    ser.Serialize(memStm, xmlbody);
                    memStm.Position = 0;

                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreWhitespace = true;

                    using (var xtr = XmlReader.Create(memStm, settings))
                    {
                        doc.Load(xtr);

                    }
                }
                string xmlResponse = ISO20022Utilities.SendRequest(doc, SystemNotificationEndpoint);
                System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\SystemsNotification(Stima)\Systemnotificationresponse(Stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", doc.OuterXml);              

            }
            catch (Exception es)
            {

            }
        }      
        private string GenerateOrderLineTransactionNumber(string requestId)
        {
            if (!string.IsNullOrWhiteSpace(requestId))
            {
                Random random = new Random(requestId.GetHashCode());

                int recordId = random.Next();

                Random rnd = new Random();

                int next = rnd.Next(99);

                return $"{recordId}{next}".PadRight(12, '0'); ;
            }
            return requestId;
        }

    }

}