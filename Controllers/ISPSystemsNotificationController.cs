using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using ISO20022Requests;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Reflection;
using ParticipantServer.ISO20022Request.SystemNotification;

namespace IPSs.Controllers
{
    [Route("sync/v1/systems-notification")]
    [ApiController]
    public class ISPSystemsNotificationController : ControllerBase
    {
        [HttpPost]
        [Consumes("application/json")]
        public string ISPSystemNotification([FromBody]IPSs.Models.ISO20022class.SystemsNotification systems)
        {
            string response = null;
            string SystemNotificationSchemaPath = GetDLLPath() + @"\xsd\admi.004.001.02.xsd";
            string EvtCd = systems.EventID;
            string EvtParam = systems.EventParameters;
            string CreateDate = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);

            string EventDesc = GenerateOrderLineTransactionNumber(Guid.NewGuid().ToString());

            string xmlns = "urn:iso:std:iso:20022:tech:xsd:admi.004.001.02";
            string SystemNotificationEndpoint = "https://api.stage.pesalink.co.ke/iso20022/async/v1/system-event-notification";

            var xmlbody = new Document
            {
                SysEvtNtfctn = new DocumentSysEvtNtfctn
                {
                    EvtInf = new DocumentSysEvtNtfctnEvtInf
                    {
                        EvtCd = EvtCd,
                        EvtDesc = EventDesc,
                        EvtParam =EvtParam,
                        EvtTm = CreateDate
                    }
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
            //compare generated XML against provided schema

            var schemas = new XmlSchemaSet();

            using (var schemaStream = System.IO.File.OpenRead(SystemNotificationSchemaPath))
            {
                var schemaXmlReader = XmlReader.Create(schemaStream);
                schemas.Add(xmlns, schemaXmlReader);

                var xmlSettings = new XmlReaderSettings
                {
                    Schemas = schemas,
                    ValidationType = ValidationType.Schema,
                    ValidationFlags =
                        XmlSchemaValidationFlags.ProcessIdentityConstraints |
                        XmlSchemaValidationFlags.ReportValidationWarnings,

                };

                var exceptions = new List<Exception>();

                xmlSettings.ValidationEventHandler += (_, args) =>
                {
                    if (args.Severity == XmlSeverityType.Warning)
                    {
                        //  Console.WriteLine(args.Message);
                        return;
                    }

                    exceptions.Add(args.Exception);
                    // Console.WriteLine(args.Exception.ToString());
                };

                // var dataFilePath = Path.Combine(directory, "file.xml");
                var dataFilePath = dest;

                using (var stream = System.IO.File.OpenRead(dataFilePath))
                {
                    using (var xmlReader = XmlReader.Create(stream, xmlSettings))
                    {
                        var serializerr = new XmlSerializer(typeof(ParticipantServer.ISO20022Request.SystemNotification.Document));
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                        var document = (ParticipantServer.ISO20022Request.SystemNotification.Document)serializerr.Deserialize(xmlReader);

                    }

                }
            }

            //
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

            System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\SystemsNotification(Stima)\Systemnotification(Stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss")+".xml", doc.OuterXml);

           // Console.ReadLine();
            return xmlResponse;
        }
        private static string GetDLLPath()
        {
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //  string certificatepath = Path.Combine(assemblyFolder, "sandbox.cer");

            return assemblyFolder;
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
