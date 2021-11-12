using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using ISO20022Requests;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Reflection;
using ParticipantServer.ISO20022Request.PaymentStatusRequest;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using RestSharp;

namespace IPSs.Controllers
{
    [Route("sync/v1/payment-status-request")]
    [ApiController]
    public class ISPPaymentstatusrequestController : ControllerBase
    {
        [HttpPost]
        [Consumes("application/json")]
        public string ISPPaymentStatusRequest([FromBody] IPSs.Models.ISO20022class.PaymentstatusrequestRequest statusrequest)
        {
            string response = null;
            string CreateDate = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
            string PaymentStatusRequestSchemaPath = GetDLLPath() + @"\xsd\pacs.028.001.04_0.xsd";
            string xmlns = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.04";
            string PaymentStatusRequestEndpoint = "https://api.stage.pesalink.co.ke/iso20022/sync/v1/payment-status-request";

            //json format
            
            string OriginalmessageId = statusrequest.MessageID;
            string DebtorPhonNb = statusrequest.SourcePhoneNo;
            string CdtrBankCode = statusrequest.DestinationBankCode;
            string DbtrId = "0089";
            string DbtrName = statusrequest.SourceAccountName;
            string DbtrAcct = statusrequest.SourceAccountNo;
            string DbtrAcctName = statusrequest.SourceAccountName;
            string DbtrAgent = "0089";
            string Amount = statusrequest.SourceAmount;
            string StsReqId = $"0089{CdtrBankCode}{DateTime.Now:yyyyMMddHHmmss}{DbtrAcct.Substring(0, 8)}";


            string MsgId = GenerateOrderLineTransactionNumber(Guid.NewGuid().ToString());
      
            string EndtoEndId = $"0089{CdtrBankCode}{DateTime.Now:yyyyMMddHHmmss}{DbtrAcct.Substring(0, 8)}";

            string Purpose = null;
            
            var xmlbody = new ParticipantServer.ISO20022Request.PaymentStatusRequest.Document
            {
                FIToFIPmtStsReq = new DocumentFIToFIPmtStsReq
                {
                    GrpHdr = new DocumentFIToFIPmtStsReqGrpHdr
                    {
                        CreDtTm = CreateDate,
                        InstdAgt = new DocumentFIToFIPmtStsReqGrpHdrInstdAgt
                        {
                            FinInstnId = new DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnId
                            {
                                Othr = new DocumentFIToFIPmtStsReqGrpHdrInstdAgtFinInstnIdOthr
                                {
                                    Id = "9999"
                                }

                            }
                        },
                        InstgAgt = new DocumentFIToFIPmtStsReqGrpHdrInstgAgt
                        {
                            FinInstnId = new DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnId
                            {
                                Othr = new DocumentFIToFIPmtStsReqGrpHdrInstgAgtFinInstnIdOthr
                                {
                                    Id = "0089"
                                }
                            }
                        },
                        MsgId = MsgId
                    },
                    OrgnlGrpInf = new DocumentFIToFIPmtStsReqOrgnlGrpInf
                    {
                        OrgnlCreDtTm = CreateDate,
                        OrgnlMsgId = OriginalmessageId,
                        OrgnlMsgNmId = "pacs.008",
                    },
                    TxInf = new DocumentFIToFIPmtStsReqTxInf
                    {
                        AccptncDtTm =CreateDate,
                        OrgnlEndToEndId = EndtoEndId,
                        OrgnlTxRef = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRef
                        {
                            //Cdtr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtr
                            //{
                            //    Pty = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPty
                            //    {
                            //        CtctDtls = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyCtctDtls
                            //        {
                            //            PhneNb = CdrtPhonNb
                            //        },
                            //        Id = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyID
                            //        {
                            //            OrgId = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgId
                            //            {
                            //                Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrPtyIDOrgIdOthr
                            //                {
                            //                    Id = "0089"
                            //                }
                            //            }

                            //        },
                            //        Nm = "32"
                            //    }
                            //},
                            //CdtrAcct = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcct
                            //{
                            //    Id = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctID
                            //    {
                            //        Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAcctIDOthr
                            //        {
                            //            Id = CdtrAcctId
                            //        }
                            //    },
                            //    Nm = CdtrAcctName,

                            //},
                            CdtrAgt = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgt
                            {
                                FinInstnId = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnId
                                {
                                    Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefCdtrAgtFinInstnIdOthr
                                    {
                                        Id =CdtrBankCode
                                    }
                                }

                            },
                            Dbtr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtr
                            {
                                Pty = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPty
                                {
                                    CtctDtls = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyCtctDtls
                                    {
                                        PhneNb = DebtorPhonNb
                                    },
                                    Id = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyID
                                    {
                                        OrgId = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgId
                                        {
                                            Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrPtyIDOrgIdOthr
                                            {
                                                Id = DbtrId
                                            }
                                        }
                                    },
                                    Nm = DbtrName
                                }

                            },
                            DbtrAcct = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcct
                            {
                                Id = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctID
                                {
                                    Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAcctIDOthr
                                    {
                                        Id = DbtrAcct
                                    }
                                },
                                Nm = DbtrAcctName
                            },
                            DbtrAgt = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgt
                            {
                                FinInstnId = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnId
                                {
                                    Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefDbtrAgtFinInstnIdOthr
                                    {
                                        Id = DbtrAgent
                                    }
                                }

                            },
                            IntrBkSttlmAmt = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefIntrBkSttlmAmt
                            {
                                Ccy = "KES",
                                Value = Amount
                            },
                            //MndtRltdInf = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInf
                            //{
                            //    CdtTrfMndt = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefMndtRltdInfCdtTrfMndt
                            //    {
                            //        MndtId = "43",

                            //    }

                            //},
                            //PmtTpInf = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInf
                            //{
                            //    CtgyPurp = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPmtTpInfCtgyPurp
                            //    {
                            //        Prtry = "34"
                            //    }
                            //},
                            //Purp = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefPurp
                            //{
                            //    Prtry = purposeoftranscation
                            //},
                            ////ReqdExctnDt = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefReqdExctnDt
                            ////{
                            ////    DtTm = ReqdExctnDt,

                            ////},
                            //RmtInf = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInf
                            //{
                            //    Strd = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrd
                            //    {
                            //        CdtrRefInf = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefRmtInfStrdCdtrRefInf
                            //        {
                            //            Ref = "43"
                            //        }

                            //    },
                            //    Ustrd =Ustrd

                            //},
                            //SttlmInf = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInf
                            //{
                            //    ClrSys = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefSttlmInfClrSys
                            //    {
                            //        Prtry = "342"
                            //    },
                            //    SttlmMtd =settlement,

                            //},
                            //UltmtCdtr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtr
                            //{
                            //    Pty = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPty
                            //    {
                            //        CtctDtls = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyCtctDtls
                            //        {
                            //            PhneNb = "+254-78946535"
                            //        },
                            //        Id = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyID
                            //        {
                            //            OrgId = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgId
                            //            {
                            //                Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtCdtrPtyIDOrgIdOthr
                            //                {
                            //                    Id = "0089"
                            //                }
                            //            }

                            //        },
                            //        Nm = "Walter"
                            //    }

                            //},
                            //UltmtDbtr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtr
                            //{
                            //    Pty = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPty
                            //    {
                            //        CtctDtls = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyCtctDtls
                            //        {
                            //            PhneNb = "+254-794962454"
                            //        },
                            //        Id = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyID
                            //        {
                            //            OrgId = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgId
                            //            {
                            //                Othr = new DocumentFIToFIPmtStsReqTxInfOrgnlTxRefUltmtDbtrPtyIDOrgIdOthr
                            //                {
                            //                    Id = UltmtDbtrid

                            //                }
                            //            }

                            //        },
                            //        Nm = "435"
                            //    }

                            //}

                        },
                        StsReqId = StsReqId
                    }
                }
            };

            //Write XML to file

            string dest = "PaymentStatusRequest.xml";

            using (XmlWriter xmlWriter = XmlWriter.Create(dest))
            {

                XmlSerializer s = new XmlSerializer(xmlbody.GetType());
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                s.Serialize(xmlWriter, xmlbody, ns);

            }
            //compare generated XML against provided schema

            var schemas = new XmlSchemaSet();

            using (var schemaStream = System.IO.File.OpenRead(PaymentStatusRequestSchemaPath))
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
                        var serializerr = new XmlSerializer(typeof(ParticipantServer.ISO20022Request.PaymentStatusRequest.Document));
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                        var document = (ParticipantServer.ISO20022Request.PaymentStatusRequest.Document)serializerr.Deserialize(xmlReader);

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

            // string xmlResponse = ISO20022Utilities.SendRequest(doc, PaymentStatusRequestEndpoint);
           string certPath = "cert/bank0089_transport.cert.pfx";
            // X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(folderPath + "bank0089_transport.cert.pfx"), ""); //path to certificate

             X509Certificate2 cert = new X509Certificate2(System.IO.File.ReadAllBytes(certPath), "");

            System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\PaymentRequest(stima)\TransferRequest\PaymentStatusRequest" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", doc.OuterXml);
            string ipsresponse = null;
            try
            {
                //sign Document before sending 
                SignXMLFile(doc, cert);

                X509CertificateCollection clientCerts = new X509CertificateCollection();
                clientCerts.Add(cert);

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                var client = new RestClient(PaymentStatusRequestEndpoint);
                client.Timeout = -1;
                client.ClientCertificates = clientCerts;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/xml");
                request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                //request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                IRestResponse responsePacs = client.Execute(request);
                ipsresponse = responsePacs.Content;

                System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\PaymentRequest(stima)\Transferreponse\Response" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", ipsresponse);

                // Console.WriteLine(ipsresponse);
            }
            catch (Exception es)
            {
                Logs.WriteLog(es.Message);
                string innerEx = "";
                if (es.InnerException != null)
                    innerEx = es.InnerException.ToString();
            }

            ////deseilze xml string response
            
               

            try
            {

                var serializer = new XmlSerializer(typeof(ISO20022Requests.PaymentStatusReport.Response.Document));
                ISO20022Requests.PaymentStatusReport.Response.Document updatestatus;

                using (TextReader reader = new StringReader(ipsresponse))
                {
                    updatestatus = (ISO20022Requests.PaymentStatusReport.Response.Document)serializer.Deserialize(reader);
                }

                // serialize incoming reponse
                var EntryNo = updatestatus.FIToFIPmtStsRpt.GrpHdr.MsgId;
                var sourceReference = updatestatus.FIToFIPmtStsRpt.OrgnlGrpInfAndSts.OrgnlMsgId;
                var sourceBankCode = updatestatus.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.DbtrAgt.FinInstnId.Othr.Id;
                var sourceAccount = updatestatus.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.DbtrAcct.Id.Othr.Id;
                var AmounttoTransfer = updatestatus.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.IntrBkSttlmAmt.Value;
                var BeneficiaryAccount = updatestatus.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.CdtrAcct.Id.Othr.Id;
                var Status = updatestatus.FIToFIPmtStsRpt.TxInfAndSts.TxSts;



                if (Status != "ACCP")//if status is Rejected
                {
                    var Reason4Rjct = updatestatus.FIToFIPmtStsRpt.TxInfAndSts.StsRsnInf.Rsn.Cd;
                    if (sourceBankCode == "0089")
                    {
                        int position = sourceReference.IndexOf('-');
                        sourceReference = sourceReference.Substring(0, position);

                        string xmlreq = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                                <Body>
                                    <UpdateTransferStatus xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                        <requestID>" + sourceReference + @"</requestID>
                                        <statusOfRequestCode>" + Reason4Rjct + @"</statusOfRequestCode>
                                    </UpdateTransferStatus>
                                </Body>
                            </Envelope>";

                        string response1 = trial.Utility.CallWebService(xmlreq);

                        response1 = trial.Utility.GetJSONResponse(response1);

                        Logs.WriteLog(response);
                    }
                   
                }
                else //if status is accepted 
                {

                    if (sourceBankCode == "0089")
                    {
                        int position = sourceReference.IndexOf('-');
                        sourceReference = sourceReference.Substring(0, position);

                        string xmlreq = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                                            <Body>
                                                <UpdateTransferStatus xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                                    <requestID>" + sourceReference + @"</requestID>
                                                    <statusOfRequestCode>" + Status + @"</statusOfRequestCode>
                                                </UpdateTransferStatus>
                                            </Body>
                                        </Envelope>";

                        string response2 = trial.Utility.CallWebService(xmlreq);

                        response2 = trial.Utility.GetJSONResponse(response2);

                        Logs.WriteLog(response2);
                    }
                   

                }
            }
            catch
            {

            }
            try
            {
                var serializer1 = new XmlSerializer(typeof(IPSs.ISO20022Request.Payementrequestresponses.Document));
                IPSs.ISO20022Request.Payementrequestresponses.Document update;

                using (TextReader reader = new StringReader(ipsresponse))
                {
                    update = (IPSs.ISO20022Request.Payementrequestresponses.Document)serializer1.Deserialize(reader);
                }

                var status = update.admi00200101.Rsn.RjctgPtyRsn;
                var Reason = update.admi00200101.Rsn.RsnDesc;
                if(status == "RJCT")
                {
                    string xmlreq = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                                <Body>
                                    <UpdateTransferStatus xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                        <requestID>" + OriginalmessageId + @"</requestID>
                                        <statusOfRequestCode>" + status + @"</statusOfRequestCode>
                                    </UpdateTransferStatus>
                                </Body>
                            </Envelope>";

                    string response1 = trial.Utility.CallWebService(xmlreq);

                    response1 = trial.Utility.GetJSONResponse(response1);

                    Logs.WriteLog(response);
                }
            }
            catch
            {

            }


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
