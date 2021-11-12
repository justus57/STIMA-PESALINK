using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using ISO20022Requests;
using ParticipantServer.ISO20022Request.AccountVerification;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Reflection;
using Newtonsoft.Json;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using RestSharp;
using System.Security.Cryptography.Xml;


namespace IPSs.Controllers
{
    [Route("sync/v1/verification")]
    [ApiController]
    public class IPSLServerController
    {
        static string certPath = "cert/bank0089_transport.cert.pfx";
        // X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(folderPath + "bank0089_transport.cert.pfx"), ""); //path to certificate
         
        static X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(certPath), ""); //path to certificate

        [HttpPost]
        [Consumes("application/json")]

        public string internalaccountVerification([FromBody] IPSs.Models.AccountVerification.AccountVerificationRequest account)
        {
            string ipsresponse = null;
            string response = null;
            
          
            string AccountVerificationSchemaPath = GetDLLPath() + @"\xsd\acmt.023.001.02.xsd"; ;
            string xmlns = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02";
            string verificationrequestEndpoint = "https://api.stage.pesalink.co.ke/iso20022/sync/v1/verification-request";
            string AccountNo = account.AccountNo;
            string BankCode = account.BackCode;
            string CreateDate = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
            string MsgId = GenerateOrderLineTransactionNumber(Guid.NewGuid().ToString());

            try
            {
                var xmlbody = new ParticipantServer.ISO20022Request.AccountVerification.Document
                {
                    IdVrfctnReq = new DocumentIdVrfctnReq
                    {
                        Assgnmt = new DocumentIdVrfctnReqAssgnmt
                        {
                            Assgne = new DocumentIdVrfctnReqAssgnmtAssgne
                            {
                                Agt = new DocumentIdVrfctnReqAssgnmtAssgneAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnReqAssgnmtAssgneAgtFinInstnIdOthr
                                        {
                                            Id = "9999"

                                        }
                                    }
                                }

                            },
                            Assgnr = new DocumentIdVrfctnReqAssgnmtAssgnr
                            {
                                Agt = new DocumentIdVrfctnReqAssgnmtAssgnrAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnReqAssgnmtAssgnrAgtFinInstnIdOthr
                                        {
                                            Id = "0089"
                                        }
                                    }
                                }
                            },
                            CreDtTm = CreateDate,

                            FrstAgt = new DocumentIdVrfctnReqAssgnmtFrstAgt
                            {
                                FinInstnId = new DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnId
                                {
                                    Othr = new DocumentIdVrfctnReqAssgnmtFrstAgtFinInstnIdOthr
                                    {
                                        Id = "0089"

                                    }
                                }
                            },
                            MsgId = MsgId
                        },
                        Vrfctn = new DocumentIdVrfctnReqVrfctn
                        {
                            Id = MsgId,
                            PtyAndAcctId = new DocumentIdVrfctnReqVrfctnPtyAndAcctId
                            {

                                Acct = new DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcct
                                {
                                    Othr = new DocumentIdVrfctnReqVrfctnPtyAndAcctIdAcctOthr
                                    {
                                        Id = AccountNo,

                                    }
                                },
                                Agt = new DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnReqVrfctnPtyAndAcctIdAgtFinInstnIdOthr
                                        {
                                            Id = BankCode
                                        }
                                    }
                                }
                            }
                        }
                    }
                };

                //Write XML to file

                string dest = "AccountVerification.xml";

                using (XmlWriter xmlWriter = XmlWriter.Create(dest))
                {

                    XmlSerializer s = new XmlSerializer(xmlbody.GetType());
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    //ns.Add("", "");
                    s.Serialize(xmlWriter, xmlbody, ns);

                }
                //compare generated XML against provided schema

                var schemas = new XmlSchemaSet();

                using (var schemaStream = System.IO.File.OpenRead(AccountVerificationSchemaPath))
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
                            var serializerr = new XmlSerializer(typeof(ParticipantServer.ISO20022Request.AccountVerification.Document));
                            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                            var document = (ParticipantServer.ISO20022Request.AccountVerification.Document)serializerr.Deserialize(xmlReader);

                        }

                    }
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

                //string xmlResponse = ISO20022Utilities.SendRequest(doc, verificationrequestEndpoint);
                try
                {
                    //sign Document before sending 
                    SignXMLFile(doc, cert);

                    X509CertificateCollection clientCerts = new X509CertificateCollection();
                    clientCerts.Add(cert);

                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    

                    var client = new RestClient("https://api.stage.pesalink.co.ke/iso20022/sync/v1/verification-request");
                    client.Timeout = -1;
                    client.ClientCertificates = clientCerts;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/xml");
                    request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                    IRestResponse response1 = client.Execute(request);
                   ipsresponse= response1.Content;
                    System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\Accountverification(stima)\Response\Accountverification(IPS)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", ipsresponse);


                    // Console.WriteLine(ipsresponse);
                }
                catch (Exception es)
                {
                    Logs.WriteLog(es.Message);
                    string innerEx = "";
                    if (es.InnerException != null)
                        innerEx = es.InnerException.ToString();
                }

                System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\Accountverification(stima)\Request\verification-request(stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss")+".xml", doc.OuterXml);




                //deseilze xml string response


                var serializer = new XmlSerializer(typeof(ISO20022Requests.AccountVerification.Response.Document));
                ISO20022Requests.AccountVerification.Response.Document accountVerificationRequest;

                using (TextReader reader = new StringReader(ipsresponse))
                {
                    accountVerificationRequest = (ISO20022Requests.AccountVerification.Response.Document)serializer.Deserialize(reader);
                }

                var requeststatus = accountVerificationRequest.IdVrfctnRpt.Rpt.Vrfctn;
                var accountName = accountVerificationRequest.IdVrfctnRpt.Rpt.UpdtdPtyAndAcctId.Pty.Nm;
                var accountNo = accountVerificationRequest.IdVrfctnRpt.Rpt.UpdtdPtyAndAcctId.Acct.Othr.Id;
                var Backcode = accountVerificationRequest.IdVrfctnRpt.Rpt.UpdtdPtyAndAcctId.Agt.FinInstnId.Othr.Id;

                //serialize to json/wrtite to file

                var xmldoc = new XmlDocument();
                xmldoc.LoadXml(ipsresponse);
                var fromXml = JsonConvert.SerializeXmlNode(xmldoc);

                Models.AccountVerification.VerificationResponse res = JsonConvert.DeserializeObject<Models.AccountVerification.VerificationResponse>(fromXml);


                res.AccountName = accountVerificationRequest.IdVrfctnRpt.Rpt.UpdtdPtyAndAcctId.Pty.Nm;
                res.AccountNumber = accountVerificationRequest.IdVrfctnRpt.Rpt.UpdtdPtyAndAcctId.Acct.Othr.Id;
                res.Backcode = accountVerificationRequest.IdVrfctnRpt.Rpt.UpdtdPtyAndAcctId.Agt.FinInstnId.Othr.Id;
                res.status= accountVerificationRequest.IdVrfctnRpt.Rpt.Vrfctn;
                bool status = requeststatus;


                Logs.WriteLog((Backcode.ToString() + " : " + AccountNo.ToString() + " : " + accountName.ToString() + ":" + requeststatus.ToString()));
                response = requeststatus + ":" + Backcode.ToString() + ":" + AccountNo.ToString() + ":" + accountName.ToString();

               response = JsonConvert.SerializeObject(response);



              
            }
            catch (Exception es)
            {
                Logs.WriteLog(es.ToString());
            }
            return response;
          
           
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
        public static void SignXMLFile(XmlDocument doc, X509Certificate2 cert)
        {
            try
            {

                SignedXml signedXml = new SignedXml(doc);
                signedXml.SigningKey = cert.PrivateKey;
                Reference reference = new Reference();
                reference.Uri = "";
                reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                signedXml.AddReference(reference);

                KeyInfo keyInfo = new KeyInfo();
                keyInfo.AddClause(new KeyInfoX509Data(cert));
                signedXml.KeyInfo = keyInfo;
                signedXml.ComputeSignature();
                XmlElement xmlSig = signedXml.GetXml();
                doc.DocumentElement.AppendChild(doc.ImportNode(xmlSig, true));
            }
            catch (Exception es)
            {
                Logs.WriteLog(es.Message);
                string innerEx = "";
                if (es.InnerException != null)
                    innerEx = es.InnerException.ToString();
            }
        }

    }
   
}
