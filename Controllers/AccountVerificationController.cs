using IPSs.ISO20022Request.AccountVerificationresponses;
using IPSs.Models.ISO20022class;
using ISO20022Requests;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Reflection;


namespace ParticipantServer.Controllers
{
    [ApiController]
    public class AccountVerificationController : ControllerBase
    {
        static string certPath = "cert/bank0089_transport.cert.pfx";
        // X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(folderPath + "bank0089_transport.cert.pfx"), ""); //path to certificate

        static X509Certificate2 cert = new X509Certificate2(System.IO.File.ReadAllBytes(certPath), ""); //path to certificate

        public bool verification { get; private set; }
       

        [HttpPost]
        [Route("v1/verification-request")]
        [Consumes("application/xml")]
        public string AccountVerification([FromBody] ISO20022Request.AccountVerification.Document model)
        {
            //log incomingXml

            string credittransferpath = @"C:\Logs\Pesalinkrequestandreposnses(xml)\Incomingxml\Accountverification(IPS)\Requests\Accountverification(IPS)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml";
            using (XmlWriter xmlWriter = XmlWriter.Create(credittransferpath))
            {

                XmlSerializer s = new XmlSerializer(model.GetType()); ;
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ///   ns.Add("", "");
                s.Serialize(xmlWriter, model, ns);

            }

            var MsgId = model.IdVrfctnReq.Assgnmt.MsgId;
            var CreDtTm = model.IdVrfctnReq.Assgnmt.CreDtTm;
            var FrstAgtid = model.IdVrfctnReq.Assgnmt.FrstAgt.FinInstnId.Othr.Id;
            var AssgnrId = model.IdVrfctnReq.Assgnmt.Assgnr.Agt.FinInstnId.Othr.Id;
            var AssgneId = model.IdVrfctnReq.Assgnmt.Assgne.Agt.FinInstnId.Othr.Id;
            var VrfctnId = model.IdVrfctnReq.Vrfctn.Id;
            var AcctId = model.IdVrfctnReq.Vrfctn.PtyAndAcctId.Acct.Othr.Id;
            //Prtry = model.IdVrfctnReq.Vrfctn.PtyAndAcctId.Acct.Othr.SchmeNm.Prtry;
            var AgtId = model.IdVrfctnReq.Vrfctn.PtyAndAcctId.Agt.FinInstnId.Othr.Id;

            //pass the account to Nav
            string ipsresponse = null;
           
            string xmlreq = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" > 
                                <Body>
                                    <CheckValidAccountDetails xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                        <accountNo>" + AcctId + @"</accountNo>
                                    </CheckValidAccountDetails>
                                </Body>
                            </Envelope>";

            string response = trial.Utility.CallWebService(xmlreq);

            response = trial.Utility.GetJSONResponse(response);
            Accountverification detailsToTransfer = JsonConvert.DeserializeObject<Accountverification>(response);
            var status1 = detailsToTransfer.Status;
            var AccountName = detailsToTransfer.AccountName;

            if(status1 == "000")
            {
                verification = true;
            }
            else
            {
                verification = false;
            }
            if (verification != true)
            {
                
               
                string AccountVerificationSchemaPath = GetDLLPath() + @"\xsd\acmt.024.001.02.xsd"; ;
                string xmlns = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02";
                
               
                string CreateDate = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
                string MessageID = GenerateOrderLineTransactionNumber(Guid.NewGuid().ToString());

                var xmlbody = new IPSs.ISO20022Request.AccountVerificationresponses.Document
                {
                    IdVrfctnRpt = new DocumentIdVrfctnRpt
                    {
                        Assgnmt = new DocumentIdVrfctnRptAssgnmt
                        {
                            Assgne = new DocumentIdVrfctnRptAssgnmtAssgne
                            {
                                Agt = new DocumentIdVrfctnRptAssgnmtAssgneAgt
                                {
                                    FinInstnId= new DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnIdOthr
                                        {
                                            Id="9999"
                                        }
                                    }
                                }
                            },
                            Assgnr = new DocumentIdVrfctnRptAssgnmtAssgnr
                            {
                                Agt = new DocumentIdVrfctnRptAssgnmtAssgnrAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnIdOthr
                                        {
                                            Id = "0089"
                                        }
                                    }
                                }
                            },
                            CreDtTm= CreateDate,
                            FrstAgt= new DocumentIdVrfctnRptAssgnmtFrstAgt
                            {
                                FinInstnId = new DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnId
                                {
                                    Othr = new DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnIdOthr
                                    {
                                        Id = "0089"
                                    }
                                }
                            },
                            MsgId= MessageID

                        },
                        OrgnlAssgnmt = new DocumentIdVrfctnRptOrgnlAssgnmt
                        {
                            CreDtTm = CreDtTm,
                            FrstAgt = new DocumentIdVrfctnRptOrgnlAssgnmtFrstAgt
                            {
                                FinInstnId = new DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnId
                                {
                                    Othr = new DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnIdOthr
                                    {
                                        Id = "0089"
                                    }
                                }
                            },
                            MsgId = MsgId
                        },
                        Rpt = new DocumentIdVrfctnRptRpt
                        {
                            OrgnlId = VrfctnId,
                            OrgnlPtyAndAcctId= new DocumentIdVrfctnRptRptOrgnlPtyAndAcctId
                            {
                                Acct = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcct
                                {
                                    Othr = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcctOthr
                                    {
                                        Id = AcctId
                                    }
                                },
                                Agt = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnIdOthr
                                        {
                                            Id = "0089"
                                        }
                                    }
                                }
                            },
                            Vrfctn = verification,
                            Rsn = new DocumentIdVrfctnRptRptRsn
                            {
                                Cd = "AC01"
                            }, 
                            //UpdtdPtyAndAcctId = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctId
                            //{
                            //    Agt = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgt
                            //    {
                            //        FinInstnId = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnId
                            //        {
                            //            Othr = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnIdOthr
                            //            {
                            //                Id= "0089"
                            //            }
                            //        }
                            //    },
                            //    Acct = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcct
                            //    {
                            //        Othr = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcctOthr
                            //        {
                            //            Id = AcctId
                            //        }
                            //    },
                            //    Pty = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdPty
                            //    {
                            //        Nm = AccountName
                            //    }
                            //}
                        }
                    }
                };

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
                            var serializerr = new XmlSerializer(typeof(IPSs.ISO20022Request.AccountVerificationresponses.Document));
                            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                            var document = (IPSs.ISO20022Request.AccountVerificationresponses.Document)serializerr.Deserialize(xmlReader);

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



                    var client = new RestClient("https://api.stage.pesalink.co.ke/iso20022/sync/v1/verification-report");
                    client.Timeout = -1;
                    client.ClientCertificates = clientCerts;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/xml");
                    request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                    IRestResponse response1 = client.Execute(request);
                    ipsresponse = response1.Content;


                    System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\Incomingxml\Accountverification(IPS)\Response\verification-request(stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", doc.OuterXml);

                    // Console.WriteLine(ipsresponse);
                }
                catch (Exception es)
                {
                    Logs.WriteLog(es.Message);
                    string innerEx = "";
                    if (es.InnerException != null)
                        innerEx = es.InnerException.ToString();
                }
            }
            else

            {
                

                string AccountVerificationSchemaPath = GetDLLPath() + @"\xsd\acmt.024.001.02.xsd"; ;
                string xmlns = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.02";


                string CreateDate = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
                string MessageID = GenerateOrderLineTransactionNumber(Guid.NewGuid().ToString());

                var xmlbody = new IPSs.ISO20022Request.AccountVerificationresponses.Document
                {
                    IdVrfctnRpt = new DocumentIdVrfctnRpt
                    {
                        Assgnmt = new DocumentIdVrfctnRptAssgnmt
                        {
                            Assgne = new DocumentIdVrfctnRptAssgnmtAssgne
                            {
                                Agt = new DocumentIdVrfctnRptAssgnmtAssgneAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnRptAssgnmtAssgneAgtFinInstnIdOthr
                                        {
                                            Id = "9999"
                                        }
                                    }
                                }
                            },
                            Assgnr = new DocumentIdVrfctnRptAssgnmtAssgnr
                            {
                                Agt = new DocumentIdVrfctnRptAssgnmtAssgnrAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnRptAssgnmtAssgnrAgtFinInstnIdOthr
                                        {
                                            Id = "0089"
                                        }
                                    }
                                }
                            },
                            CreDtTm = CreateDate,
                            FrstAgt = new DocumentIdVrfctnRptAssgnmtFrstAgt
                            {
                                FinInstnId = new DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnId
                                {
                                    Othr = new DocumentIdVrfctnRptAssgnmtFrstAgtFinInstnIdOthr
                                    {
                                        Id = "0089"
                                    }
                                }
                            },
                            MsgId = MessageID

                        },
                        OrgnlAssgnmt = new DocumentIdVrfctnRptOrgnlAssgnmt
                        {
                            CreDtTm = CreDtTm,
                            FrstAgt = new DocumentIdVrfctnRptOrgnlAssgnmtFrstAgt
                            {
                                FinInstnId = new DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnId
                                {
                                    Othr = new DocumentIdVrfctnRptOrgnlAssgnmtFrstAgtFinInstnIdOthr
                                    {
                                        Id = "0089"
                                    }
                                }
                            },
                            MsgId = MsgId
                        },
                        Rpt = new DocumentIdVrfctnRptRpt
                        {
                            OrgnlId = VrfctnId,
                            OrgnlPtyAndAcctId = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctId
                            {
                                Acct = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcct
                                {
                                    Othr = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAcctOthr
                                    {
                                        Id = AcctId
                                    }
                                },
                                Agt = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnRptRptOrgnlPtyAndAcctIdAgtFinInstnIdOthr
                                        {
                                            Id = "0089"
                                        }
                                    }
                                }
                            },
                            Vrfctn = verification,
                            //Rsn = new DocumentIdVrfctnRptRptRsn
                            //{
                            //    Cd = "AC01"
                            //},
                            UpdtdPtyAndAcctId = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctId
                            {
                                Agt = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgt
                                {
                                    FinInstnId = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnId
                                    {
                                        Othr = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAgtFinInstnIdOthr
                                        {
                                            Id = "0089"
                                        }
                                    }
                                },
                                Acct = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcct
                                {
                                    Othr = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdAcctOthr
                                    {
                                        Id = AcctId
                                    }
                                },
                                Pty = new DocumentIdVrfctnRptRptUpdtdPtyAndAcctIdPty
                                {
                                    Nm = AccountName
                                }
                            }
                        }
                    }
                };

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
                            var serializerr = new XmlSerializer(typeof(IPSs.ISO20022Request.AccountVerificationresponses.Document));
                            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                            var document = (IPSs.ISO20022Request.AccountVerificationresponses.Document)serializerr.Deserialize(xmlReader);

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



                    var client = new RestClient("https://api.stage.pesalink.co.ke/iso20022/sync/v1/verification-report");
                    client.Timeout = -1;
                    client.ClientCertificates = clientCerts;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/xml");
                    request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                    IRestResponse response1 = client.Execute(request);
                    ipsresponse = response1.Content;

                    System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\Incomingxml\Accountverification(IPS)\Response\verification-request(stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", doc.OuterXml);
                    Logs.WriteLog(ipsresponse);


                    // Console.WriteLine(ipsresponse);
                }
                catch (Exception es)
                {
                    Logs.WriteLog(es.Message);
                    string innerEx = "";
                    if (es.InnerException != null)
                        innerEx = es.InnerException.ToString();
                }
            }

            Logs.WriteLog(response);


            
            return ipsresponse;
            


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