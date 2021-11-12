using ISO20022Requests;
using ParticipantServer.ISO20022Request.PaymentStatusReport;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using IPSs.Models.AccountVerification;
using Nancy.Json;
using IPSs.Models.ISO20022class;
using Newtonsoft.Json;

namespace ParticipantServer.Controllers
{
    [ApiController]
    [Route("v1/credit-transfer")]

    public class CreditTransferController 
    {
        static string certPath = "cert/bank0089_transport.cert.pfx";
        // X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(folderPath + "bank0089_transport.cert.pfx"), ""); //path to certificate

        static X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(certPath), ""); //path to certificatetificate

        [HttpPost]
        [Consumes("application/xml")]
        public string CreditTransfer([FromBody] ISO20022Request.CreditTransfer.Document model)
        {

            //log incomingXml

            string credittransferpath = @"C:\Logs\Pesalinkrequestandreposnses(xml)\Incomingxml\Credit transfer(ips)\Credit transfer(ips)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml";
            using (XmlWriter xmlWriter = XmlWriter.Create(credittransferpath))
            {

                XmlSerializer s = new XmlSerializer(model.GetType()); ;
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ///   ns.Add("", "");
                s.Serialize(xmlWriter, model, ns);

            }


            //pass the incomingxml to get values

            var OrgnlMsgId = model.FIToFICstmrCdtTrf.GrpHdr.MsgId;
            var OrgnlCreDtTm = model.FIToFICstmrCdtTrf.GrpHdr.CreDtTm;
            var NbOfTxs = model.FIToFICstmrCdtTrf.GrpHdr.NbOfTxs;
            var SttlmMtd = model.FIToFICstmrCdtTrf.GrpHdr.SttlmInf.SttlmMtd;
            var ClrSys = model.FIToFICstmrCdtTrf.GrpHdr.SttlmInf.ClrSys.Prtry;
            var SvcLvl = model.FIToFICstmrCdtTrf.GrpHdr.PmtTpInf.SvcLvl.Prtry;
            var LclInstrm = model.FIToFICstmrCdtTrf.GrpHdr.PmtTpInf.LclInstrm.Cd;
            var CtgyPurp = model.FIToFICstmrCdtTrf.GrpHdr.PmtTpInf.CtgyPurp.Prtry;
            var InstdAgt = model.FIToFICstmrCdtTrf.GrpHdr.InstdAgt.FinInstnId.Othr.Id;
            var InstgAgt = model.FIToFICstmrCdtTrf.GrpHdr.InstdAgt.FinInstnId.Othr.Id;
            var OrgnlEndToEndId = model.FIToFICstmrCdtTrf.CdtTrfTxInf.PmtId.EndToEndId;
            var Amount = model.FIToFICstmrCdtTrf.CdtTrfTxInf.IntrBkSttlmAmt.Value;
            var Currency = model.FIToFICstmrCdtTrf.CdtTrfTxInf.IntrBkSttlmAmt.Ccy;
            var AccptncDtTm = model.FIToFICstmrCdtTrf.CdtTrfTxInf.AccptncDtTm;
            var ChrgBr = model.FIToFICstmrCdtTrf.CdtTrfTxInf.ChrgBr;
            var DbtrNm = model.FIToFICstmrCdtTrf.CdtTrfTxInf.Dbtr.Nm;
            var DbtrAcct = model.FIToFICstmrCdtTrf.CdtTrfTxInf.DbtrAcct.Id.Othr.Id;
            var DbtrPhneNb = model.FIToFICstmrCdtTrf.CdtTrfTxInf.Dbtr.CtctDtls.PhneNb;
            var Bankcode = model.FIToFICstmrCdtTrf.CdtTrfTxInf.CdtrAgt.FinInstnId.Othr.Id;
            var DbtrAgt = model.FIToFICstmrCdtTrf.CdtTrfTxInf.DbtrAgt.FinInstnId.Othr.Id;
            var Cdtr = model.FIToFICstmrCdtTrf.CdtTrfTxInf.Cdtr;
            var Accountno = model.FIToFICstmrCdtTrf.CdtTrfTxInf.CdtrAcct.Id.Othr.Id;
            var Purp = model.FIToFICstmrCdtTrf.CdtTrfTxInf.Purp.Prtry;
            var Ustrd = model.FIToFICstmrCdtTrf.CdtTrfTxInf.RmtInf.Ustrd;


            bool status = true;
            var res = new VerificationResponse { };
            string rs = null;
            try
            {
                if (Bankcode  == "0089")
                {
                   
                    // Account verification
                    string xmlreq = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" > 
                                <Body>
                                    <CheckValidAccountDetails xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                        <accountNo>" + Accountno + @"</accountNo>
                                    </CheckValidAccountDetails>
                                </Body>
                            </Envelope>";

                    string response = trial.Utility.CallWebService(xmlreq);

                    response = trial.Utility.GetJSONResponse(response);
                    Logs.WriteLog(response);
                    Accountverification detailsToTransfer = JsonConvert.DeserializeObject<Accountverification>(response);
                    var status1 = detailsToTransfer.Status;
                    var Name = detailsToTransfer.AccountName;

                    if (status1 == "000")
                    {
                        string xmlrequest = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" >
                                    <Body>
                                        <InsertDepositEntry xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                            <sourceReferenceNo> " + OrgnlMsgId + @" </sourceReferenceNo>
                                            <sourceBankCode>" + DbtrAgt + @"</sourceBankCode>
                                            <sourceAccountNo>" + DbtrAcct + @"</sourceAccountNo>
                                            <sourceAccountName>" + DbtrNm + @"</sourceAccountName>
                                            <sourcePhoneNo>"+ DbtrPhneNb + @"</sourcePhoneNo>
                                            <purpose>" + Purp + @"</purpose>
                                            <amountToTransfer>" + Amount + @"</amountToTransfer>
                                            <destinationAccountNo>" + Accountno + @"</destinationAccountNo>
                                        </InsertDepositEntry>
                                    </Body>
                                </Envelope>";
                        string responses = trial.Utility.CallWebService(xmlrequest);



                        responses = trial.Utility.GetJSONResponse(responses);
                        Depositentry details = JsonConvert.DeserializeObject<Depositentry>(response);
                        var Status = details.Status;
                        //check status 
                        if (Status == "000")
                        {
                            string CreateDate = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
                            string MsgId = $"0089{Bankcode}{OrgnlMsgId.Substring(0, 8)}";
                            var xmlbody = new Document
                            {
                                FIToFIPmtStsRpt = new DocumentFIToFIPmtStsRpt
                                {
                                    GrpHdr = new DocumentFIToFIPmtStsRptGrpHdr
                                    {
                                        CreDtTm = CreateDate,
                                        MsgId = MsgId,
                                        InstdAgt = new DocumentFIToFIPmtStsRptGrpHdrInstdAgt
                                        {
                                            FinInstnId = new DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnId
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnIdOthr
                                                {
                                                    Id = "9999"
                                                }
                                            }
                                        },
                                        InstgAgt = new DocumentFIToFIPmtStsRptGrpHdrInstgAgt
                                        {
                                            FinInstnId = new DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnId
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnIdOthr
                                                {
                                                    Id = InstgAgt
                                                }
                                            }
                                        }
                                    },
                                    OrgnlGrpInfAndSts = new DocumentFIToFIPmtStsRptOrgnlGrpInfAndSts
                                    {
                                        OrgnlCreDtTm = OrgnlCreDtTm,
                                        OrgnlMsgId = OrgnlMsgId,
                                        OrgnlMsgNmId = "pacs.008"
                                    },
                                    TxInfAndSts = new DocumentFIToFIPmtStsRptTxInfAndSts
                                    {
                                        AccptncDtTm = CreateDate,
                                        OrgnlEndToEndId = OrgnlEndToEndId,
                                        OrgnlTxRef = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRef
                                        {
                                            Cdtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtr
                                            {
                                                Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPty
                                                {CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyCtctDtls { PhneNb = "+254-703024000" },
                                                    Nm = "STIMA SACCO SOCIETY"
                                                }
                                            },
                                            CdtrAcct = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcct
                                            {
                                                Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctID
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthr
                                                    {
                                                        Id = Accountno,
                                                        //SchmeNm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthrSchmeNm
                                                        //{
                                                        //    Prtry = "IPS"
                                                        //}
                                                    }
                                                }
                                            },
                                            CdtrAgt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgt
                                            {
                                                FinInstnId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnId
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnIdOthr
                                                    {
                                                        Id = Bankcode
                                                    }
                                                }
                                            },
                                            Dbtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtr
                                            {
                                                Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPty
                                                {
                                                    CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyCtctDtls
                                                    {
                                                        PhneNb = DbtrPhneNb
                                                    },
                                                    //Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyID
                                                    //{
                                                    //     OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyIDOrgId
                                                    //     {
                                                    //         Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyIDOrgIdOthr
                                                    //         {
                                                    //             Id = "801004905900"
                                                    //         }
                                                    //     }

                                                    //},
                                                    Nm = DbtrNm
                                                }
                                            },
                                            DbtrAcct = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcct
                                            {
                                                Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctID
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthr
                                                    {
                                                        Id = DbtrAcct,
                                                        //SchmeNm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthrSchmeNm
                                                        //{
                                                        //    Prtry = "+254-0748106202"
                                                        //}
                                                    }
                                                },
                                                // Nm = ""
                                            },
                                            DbtrAgt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgt
                                            {
                                                FinInstnId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnId
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnIdOthr
                                                    {
                                                        Id = DbtrAgt
                                                    }
                                                }
                                            },
                                            //UltmtCdtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtr
                                            //{
                                            //    Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPty
                                            //    {
                                            //        CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyCtctDtls
                                            //        {
                                            //            PhneNb = "+254-718456352"
                                            //        },
                                            //        Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyID
                                            //        {
                                            //            OrgId= new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyIDOrgId
                                            //            {
                                            //                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyIDOrgIdOthr
                                            //                {
                                            //                    Id = "0089"
                                            //                }
                                            //            }
                                            //        },Nm ="IPSL"
                                            //    }
                                            //},
                                            //UltmtDbtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtr
                                            //{
                                            //    Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPty
                                            //    {
                                            //        CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyCtctDtls
                                            //        {
                                            //            PhneNb = "+254-789946244"
                                            //        },
                                            //        Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyID
                                            //        {
                                            //            OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyIDOrgId
                                            //            {
                                            //                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyIDOrgIdOthr
                                            //                {
                                            //                    Id = "0089"
                                            //                }
                                            //            }
                                            //        },
                                            //        Nm ="STIMA"
                                            //    }
                                            //},
                                            IntrBkSttlmAmt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefIntrBkSttlmAmt
                                            {
                                                Ccy = "KES",
                                                Value = Amount
                                            },


                                            PmtTpInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInf
                                            {
                                                CtgyPurp = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfCtgyPurp
                                                {
                                                    Prtry = CtgyPurp
                                                },
                                                LclInstrm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfLclInstrm
                                                {
                                                    Cd = LclInstrm
                                                },
                                                SvcLvl = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfSvcLvl
                                                {
                                                    Prtry = SvcLvl
                                                }
                                            },
                                            Purp = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPurp
                                            {
                                                Prtry = Purp
                                            },
                                            ReqdExctnDt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefReqdExctnDt
                                            {
                                                DtTm = CreateDate
                                            },
                                            RmtInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInf
                                            {
                                                //Strd = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInfStrd
                                                //{
                                                //    CdtrRefInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInfStrdCdtrRefInf
                                                //    {
                                                //        Ref = "0089008920210504122043fb4d4aerq"
                                                //    }
                                                //},
                                                Ustrd = Ustrd
                                            },
                                            SttlmInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInf
                                            {
                                                ClrSys = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInfClrSys
                                                {
                                                    Prtry = ClrSys
                                                },
                                                SttlmMtd = SttlmMtd
                                            }


                                        },
                                        StsId = MsgId,
                                        //StsRsnInf = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInf
                                        //{
                                        //    Orgtr = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtr
                                        //    {
                                        //        Id = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrID
                                        //        {
                                        //            OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgId
                                        //            {
                                        //                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgIdOthr
                                        //                {
                                        //                    Id = "0089"
                                        //                }
                                        //            }
                                        //        }
                                        //    },
                                        //    Rsn = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfRsn
                                        //    {
                                        //        Cd = "AC01"
                                        //    }
                                        //},
                                        TxSts = "ACCP"
                                        /* TxSts = "RJCT*/
                                    }
                                }
                            };
                            string PaymentStatusReportSchemaPath = @"xsd/pacs.002.001.11.xsd";
                            string xmlns = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11";
                            string PaymentStatusReportEndpoint = "https://api.stage.pesalink.co.ke/iso20022/async/v1/payment-status-report";

                            string dest = "PaymentStatusReport.xml";

                            using (XmlWriter xmlWriter = XmlWriter.Create(dest))
                            {

                                XmlSerializer s = new XmlSerializer(xmlbody.GetType());
                                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                                ns.Add("", "");
                                s.Serialize(xmlWriter, xmlbody, ns);

                            }
                            var schemas = new XmlSchemaSet();

                            using (var schemaStream = File.OpenRead(PaymentStatusReportSchemaPath))
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
                                var dataFilePath = dest;

                                using (var streama = File.OpenRead(dataFilePath))
                                {
                                    using (var xmlReader = XmlReader.Create(streama, xmlSettings))
                                    {
                                        //StreamReader reader = new StreamReader(streama, Encoding.UTF8);
                                        var serializerr = new XmlSerializer(typeof(Document));
                                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                                        var document = (Document)serializerr.Deserialize(xmlReader);

                                    }

                                }

                            }

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
                            // string xmlResponse = ISO20022Utilities.SendRequest(doc, PaymentStatusReportEndpoint);
                            System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\paymentstatusreport(stima)\paymentstatusreport" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", doc.InnerXml);
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

                                var client = new RestClient(PaymentStatusReportEndpoint);
                                client.Timeout = -1;
                                client.ClientCertificates = clientCerts;
                                var request = new RestRequest(Method.POST);
                                request.AddHeader("Content-Type", "application/xml");
                                request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                                //request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                                IRestResponse restResponse = client.Execute(request);
                                ipsresponse = restResponse.Content;


                            }
                            catch (Exception es)
                            {
                                Logs.WriteLog(es.Message);
                            }
                        }
                        else
                        {
                            string CreateDate1 = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
                            string MsgId1 = $"0089{Bankcode}{OrgnlMsgId.Substring(0, 8)}";
                            var xmlbody = new Document
                            {
                                FIToFIPmtStsRpt = new DocumentFIToFIPmtStsRpt
                                {
                                    GrpHdr = new DocumentFIToFIPmtStsRptGrpHdr
                                    {
                                        CreDtTm = CreateDate1,
                                        MsgId = MsgId1,
                                        InstdAgt = new DocumentFIToFIPmtStsRptGrpHdrInstdAgt
                                        {
                                            FinInstnId = new DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnId
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnIdOthr
                                                {
                                                    Id = "9999"
                                                }
                                            }
                                        },
                                        InstgAgt = new DocumentFIToFIPmtStsRptGrpHdrInstgAgt
                                        {
                                            FinInstnId = new DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnId
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnIdOthr
                                                {
                                                    Id = InstgAgt
                                                }
                                            }
                                        }
                                    },
                                    OrgnlGrpInfAndSts = new DocumentFIToFIPmtStsRptOrgnlGrpInfAndSts
                                    {
                                        OrgnlCreDtTm = OrgnlCreDtTm,
                                        OrgnlMsgId = OrgnlMsgId,
                                        OrgnlMsgNmId = "pacs.008"
                                    },
                                    TxInfAndSts = new DocumentFIToFIPmtStsRptTxInfAndSts
                                    {
                                        AccptncDtTm = CreateDate1,
                                        OrgnlEndToEndId = OrgnlEndToEndId,
                                        OrgnlTxRef = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRef
                                        {
                                            Cdtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtr
                                            {
                                                Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPty
                                                {
                                                    CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyCtctDtls
                                                    {
                                                        PhneNb = "+254-703024000",

                                                    },
                                                    //Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyID
                                                    //{
                                                    //    OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyIDOrgId
                                                    //    {
                                                    //        Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyIDOrgIdOthr
                                                    //        {
                                                    //            Id = "801007281900"
                                                    //        }
                                                    //    }
                                                    //},
                                                    Nm = "STIMA SACCO SOCIETY"
                                                }
                                            },
                                            CdtrAcct = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcct
                                            {
                                                Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctID
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthr
                                                    {
                                                        Id = Accountno,
                                                        //SchmeNm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthrSchmeNm
                                                        //{
                                                        //    Prtry = "IPS"
                                                        //}
                                                    }
                                                }
                                            },
                                            CdtrAgt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgt
                                            {
                                                FinInstnId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnId
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnIdOthr
                                                    {
                                                        Id = Bankcode
                                                    }
                                                }
                                            },
                                            Dbtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtr
                                            {
                                                Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPty
                                                {
                                                    CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyCtctDtls
                                                    {
                                                        PhneNb = DbtrPhneNb
                                                    },
                                                    //Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyID
                                                    //{
                                                    //     OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyIDOrgId
                                                    //     {
                                                    //         Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyIDOrgIdOthr
                                                    //         {
                                                    //             Id = "801004905900"
                                                    //         }
                                                    //     }

                                                    //},
                                                    Nm = DbtrNm
                                                }
                                            },
                                            DbtrAcct = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcct
                                            {
                                                Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctID
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthr
                                                    {
                                                        Id = DbtrAcct,
                                                        //SchmeNm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthrSchmeNm
                                                        //{
                                                        //    Prtry = "+254-0748106202"
                                                        //}
                                                    }
                                                },
                                                // Nm = ""
                                            },
                                            DbtrAgt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgt
                                            {
                                                FinInstnId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnId
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnIdOthr
                                                    {
                                                        Id = DbtrAgt
                                                    }
                                                }
                                            },
                                            //UltmtCdtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtr
                                            //{
                                            //    Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPty
                                            //    {
                                            //        CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyCtctDtls
                                            //        {
                                            //            PhneNb = "+254-718456352"
                                            //        },
                                            //        Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyID
                                            //        {
                                            //            OrgId= new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyIDOrgId
                                            //            {
                                            //                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyIDOrgIdOthr
                                            //                {
                                            //                    Id = "0089"
                                            //                }
                                            //            }
                                            //        },Nm ="IPSL"
                                            //    }
                                            //},
                                            //UltmtDbtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtr
                                            //{
                                            //    Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPty
                                            //    {
                                            //        CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyCtctDtls
                                            //        {
                                            //            PhneNb = "+254-789946244"
                                            //        },
                                            //        Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyID
                                            //        {
                                            //            OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyIDOrgId
                                            //            {
                                            //                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyIDOrgIdOthr
                                            //                {
                                            //                    Id = "0089"
                                            //                }
                                            //            }
                                            //        },
                                            //        Nm ="STIMA"
                                            //    }
                                            //},
                                            IntrBkSttlmAmt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefIntrBkSttlmAmt
                                            {
                                                Ccy = "KES",
                                                Value = Amount
                                            },


                                            PmtTpInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInf
                                            {
                                                CtgyPurp = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfCtgyPurp
                                                {
                                                    Prtry = CtgyPurp
                                                },
                                                LclInstrm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfLclInstrm
                                                {
                                                    Cd = LclInstrm
                                                },
                                                SvcLvl = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfSvcLvl
                                                {
                                                    Prtry = SvcLvl
                                                }
                                            },
                                            Purp = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPurp
                                            {
                                                Prtry = Purp
                                            },
                                            ReqdExctnDt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefReqdExctnDt
                                            {
                                                DtTm = CreateDate1
                                            },
                                            RmtInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInf
                                            {
                                                //Strd = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInfStrd
                                                //{
                                                //    CdtrRefInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInfStrdCdtrRefInf
                                                //    {
                                                //        Ref = "0089008920210504122043fb4d4aerq"
                                                //    }
                                                //},
                                                Ustrd = Ustrd
                                            },
                                            SttlmInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInf
                                            {
                                                ClrSys = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInfClrSys
                                                {
                                                    Prtry = ClrSys
                                                },
                                                SttlmMtd = SttlmMtd
                                            }


                                        },
                                        StsId = MsgId1,
                                        StsRsnInf = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInf
                                        {
                                            Orgtr = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtr
                                            {
                                                Id = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrID
                                                {
                                                    OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgId
                                                    {
                                                        Othr = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgIdOthr
                                                        {
                                                            Id = "0089"
                                                        }
                                                    }
                                                }
                                            },
                                            Rsn = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfRsn
                                            {
                                                Cd = "AG09"
                                            }
                                        },
                                        //TxSts = "ACCP"
                                        TxSts = "RJCT"
                                    }
                                }
                            };
                            string PaymentStatusReportSchemaPath1 = @"xsd/pacs.002.001.11.xsd";
                            string xmlns1 = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11";
                            string PaymentStatusReportEndpoint1 = "https://api.stage.pesalink.co.ke/iso20022/async/v1/payment-status-report";

                            string dest2 = "PaymentStatusReport.xml";

                            using (XmlWriter xmlWriter = XmlWriter.Create(dest2))
                            {

                                XmlSerializer s = new XmlSerializer(xmlbody.GetType());
                                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                                ns.Add("", "");
                                s.Serialize(xmlWriter, xmlbody, ns);

                            }
                            var schemas2 = new XmlSchemaSet();

                            using (var schemaStream = File.OpenRead(PaymentStatusReportSchemaPath1))
                            {
                                var schemaXmlReader = XmlReader.Create(schemaStream);
                                schemas2.Add(xmlns1, schemaXmlReader);

                                var xmlSettings = new XmlReaderSettings
                                {
                                    Schemas = schemas2,
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
                                var dataFilePath = dest2;

                                using (var streama = File.OpenRead(dataFilePath))
                                {
                                    using (var xmlReader = XmlReader.Create(streama, xmlSettings))
                                    {
                                        //StreamReader reader = new StreamReader(streama, Encoding.UTF8);
                                        var serializerr = new XmlSerializer(typeof(Document));
                                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                                        var document = (Document)serializerr.Deserialize(xmlReader);

                                    }

                                }

                            }
                            XmlDocument doc2 = new XmlDocument();
                            XmlSerializer ser2 = new XmlSerializer(xmlbody.GetType(), "");
                            using (MemoryStream memStm = new MemoryStream())
                            {
                                ser2.Serialize(memStm, xmlbody);
                                memStm.Position = 0;

                                XmlReaderSettings settings = new XmlReaderSettings();
                                settings.IgnoreWhitespace = true;

                                using (var xtr = XmlReader.Create(memStm, settings))
                                {
                                    doc2.Load(xtr);

                                }
                            }
                            //string xmlResponse = ISO20022Utilities.SendRequest(doc2, PaymentStatusReportEndpoint1);
                            System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\paymentstatusreport(stima)\paymentstatusreport(stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", doc2.InnerXml);
                            string ipsresponse = null;
                            try
                            {
                                //sign Document before sending 
                                SignXMLFile(doc2, cert);

                                X509CertificateCollection clientCerts = new X509CertificateCollection();
                                clientCerts.Add(cert);

                                ServicePointManager.Expect100Continue = true;
                                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                                var client = new RestClient(PaymentStatusReportEndpoint1);
                                client.Timeout = -1;
                                client.ClientCertificates = clientCerts;
                                var request = new RestRequest(Method.POST);
                                request.AddHeader("Content-Type", "application/xml");
                                request.AddParameter("application/xml", doc2.OuterXml, ParameterType.RequestBody);
                                //request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                                IRestResponse Rejected = client.Execute(request);
                                ipsresponse = Rejected.Content;

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
                    }
                    else
                    {

                        string CreateDate1 = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
                        string MsgId1 = $"0089{Bankcode}{OrgnlMsgId.Substring(0, 8)}";
                        var xmlbody = new Document
                        {
                            FIToFIPmtStsRpt = new DocumentFIToFIPmtStsRpt
                            {
                                GrpHdr = new DocumentFIToFIPmtStsRptGrpHdr
                                {
                                    CreDtTm = CreateDate1,
                                    MsgId = MsgId1,
                                    InstdAgt = new DocumentFIToFIPmtStsRptGrpHdrInstdAgt
                                    {
                                        FinInstnId = new DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnId
                                        {
                                            Othr = new DocumentFIToFIPmtStsRptGrpHdrInstdAgtFinInstnIdOthr
                                            {
                                                Id = "9999"
                                            }
                                        }
                                    },
                                    InstgAgt = new DocumentFIToFIPmtStsRptGrpHdrInstgAgt
                                    {
                                        FinInstnId = new DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnId
                                        {
                                            Othr = new DocumentFIToFIPmtStsRptGrpHdrInstgAgtFinInstnIdOthr
                                            {
                                                Id = InstgAgt
                                            }
                                        }
                                    }
                                },
                                OrgnlGrpInfAndSts = new DocumentFIToFIPmtStsRptOrgnlGrpInfAndSts
                                {
                                    OrgnlCreDtTm = OrgnlCreDtTm,
                                    OrgnlMsgId = OrgnlMsgId,
                                    OrgnlMsgNmId = "pacs.008"
                                },
                                TxInfAndSts = new DocumentFIToFIPmtStsRptTxInfAndSts
                                {
                                    AccptncDtTm = CreateDate1,
                                    OrgnlEndToEndId = OrgnlEndToEndId,
                                    OrgnlTxRef = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRef
                                    {
                                        Cdtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtr
                                        {
                                            Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPty
                                            {
                                                CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyCtctDtls
                                                {
                                                    PhneNb = "+254-703024000",

                                                },
                                                //Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyID
                                                //{
                                                //    OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyIDOrgId
                                                //    {
                                                //        Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrPtyIDOrgIdOthr
                                                //        {
                                                //            Id = "801007281900"
                                                //        }
                                                //    }
                                                //},
                                                Nm = "STIMA SACCO SOCIETY"
                                            }
                                        },
                                        CdtrAcct = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcct
                                        {
                                            Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctID
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthr
                                                {
                                                    Id = Accountno,
                                                    //SchmeNm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAcctIDOthrSchmeNm
                                                    //{
                                                    //    Prtry = "IPS"
                                                    //}
                                                }
                                            }
                                        },
                                        CdtrAgt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgt
                                        {
                                            FinInstnId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnId
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefCdtrAgtFinInstnIdOthr
                                                {
                                                    Id = Bankcode
                                                }
                                            }
                                        },
                                        Dbtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtr
                                        {
                                            Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPty
                                            {
                                                CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyCtctDtls
                                                {
                                                    PhneNb = DbtrPhneNb
                                                },
                                                //Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyID
                                                //{
                                                //     OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyIDOrgId
                                                //     {
                                                //         Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrPtyIDOrgIdOthr
                                                //         {
                                                //             Id = "801004905900"
                                                //         }
                                                //     }

                                                //},
                                                Nm = DbtrNm
                                            }
                                        },
                                        DbtrAcct = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcct
                                        {
                                            Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctID
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthr
                                                {
                                                    Id = DbtrAcct,
                                                    //SchmeNm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAcctIDOthrSchmeNm
                                                    //{
                                                    //    Prtry = "+254-0748106202"
                                                    //}
                                                }
                                            },
                                            // Nm = ""
                                        },
                                        DbtrAgt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgt
                                        {
                                            FinInstnId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnId
                                            {
                                                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefDbtrAgtFinInstnIdOthr
                                                {
                                                    Id = DbtrAgt
                                                }
                                            }
                                        },
                                        //UltmtCdtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtr
                                        //{
                                        //    Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPty
                                        //    {
                                        //        CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyCtctDtls
                                        //        {
                                        //            PhneNb = "+254-718456352"
                                        //        },
                                        //        Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyID
                                        //        {
                                        //            OrgId= new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyIDOrgId
                                        //            {
                                        //                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtCdtrPtyIDOrgIdOthr
                                        //                {
                                        //                    Id = "0089"
                                        //                }
                                        //            }
                                        //        },Nm ="IPSL"
                                        //    }
                                        //},
                                        //UltmtDbtr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtr
                                        //{
                                        //    Pty = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPty
                                        //    {
                                        //        CtctDtls = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyCtctDtls
                                        //        {
                                        //            PhneNb = "+254-789946244"
                                        //        },
                                        //        Id = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyID
                                        //        {
                                        //            OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyIDOrgId
                                        //            {
                                        //                Othr = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefUltmtDbtrPtyIDOrgIdOthr
                                        //                {
                                        //                    Id = "0089"
                                        //                }
                                        //            }
                                        //        },
                                        //        Nm ="STIMA"
                                        //    }
                                        //},
                                        IntrBkSttlmAmt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefIntrBkSttlmAmt
                                        {
                                            Ccy = "KES",
                                            Value = Amount
                                        },


                                        PmtTpInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInf
                                        {
                                            CtgyPurp = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfCtgyPurp
                                            {
                                                Prtry = CtgyPurp
                                            },
                                            LclInstrm = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfLclInstrm
                                            {
                                                Cd = LclInstrm
                                            },
                                            SvcLvl = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPmtTpInfSvcLvl
                                            {
                                                Prtry = SvcLvl
                                            }
                                        },
                                        Purp = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefPurp
                                        {
                                            Prtry = Purp
                                        },
                                        ReqdExctnDt = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefReqdExctnDt
                                        {
                                            DtTm = CreateDate1
                                        },
                                        RmtInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInf
                                        {
                                            //Strd = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInfStrd
                                            //{
                                            //    CdtrRefInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefRmtInfStrdCdtrRefInf
                                            //    {
                                            //        Ref = "0089008920210504122043fb4d4aerq"
                                            //    }
                                            //},
                                            Ustrd = Ustrd
                                        },
                                        SttlmInf = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInf
                                        {
                                            ClrSys = new DocumentFIToFIPmtStsRptTxInfAndStsOrgnlTxRefSttlmInfClrSys
                                            {
                                                Prtry = ClrSys
                                            },
                                            SttlmMtd = SttlmMtd
                                        }


                                    },
                                    StsId = MsgId1,
                                    StsRsnInf = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInf
                                    {
                                        Orgtr = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtr
                                        {
                                            Id = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrID
                                            {
                                                OrgId = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgId
                                                {
                                                    Othr = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfOrgtrIDOrgIdOthr
                                                    {
                                                        Id = "0089"
                                                    }
                                                }
                                            }
                                        },
                                        Rsn = new DocumentFIToFIPmtStsRptTxInfAndStsStsRsnInfRsn
                                        {
                                            Cd = "AC01"
                                        }
                                    },
                                    //TxSts = "ACCP"
                                    TxSts = "RJCT"
                                }
                            }
                        };
                        string PaymentStatusReportSchemaPath1 = @"xsd/pacs.002.001.11.xsd";
                        string xmlns1 = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.11";
                        string PaymentStatusReportEndpoint1 = "https://api.stage.pesalink.co.ke/iso20022/async/v1/payment-status-report";

                        string dest2 = "PaymentStatusReport.xml";

                        using (XmlWriter xmlWriter = XmlWriter.Create(dest2))
                        {

                            XmlSerializer s = new XmlSerializer(xmlbody.GetType());
                            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                            ns.Add("", "");
                            s.Serialize(xmlWriter, xmlbody, ns);

                        }
                        var schemas2 = new XmlSchemaSet();

                        using (var schemaStream = File.OpenRead(PaymentStatusReportSchemaPath1))
                        {
                            var schemaXmlReader = XmlReader.Create(schemaStream);
                            schemas2.Add(xmlns1, schemaXmlReader);

                            var xmlSettings = new XmlReaderSettings
                            {
                                Schemas = schemas2,
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
                            var dataFilePath = dest2;

                            using (var streama = File.OpenRead(dataFilePath))
                            {
                                using (var xmlReader = XmlReader.Create(streama, xmlSettings))
                                {
                                    //StreamReader reader = new StreamReader(streama, Encoding.UTF8);
                                    var serializerr = new XmlSerializer(typeof(Document));
                                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                                    var document = (Document)serializerr.Deserialize(xmlReader);

                                }

                            }

                        }
                        XmlDocument doc2 = new XmlDocument();
                        XmlSerializer ser2 = new XmlSerializer(xmlbody.GetType(), "");
                        using (MemoryStream memStm = new MemoryStream())
                        {
                            ser2.Serialize(memStm, xmlbody);
                            memStm.Position = 0;

                            XmlReaderSettings settings = new XmlReaderSettings();
                            settings.IgnoreWhitespace = true;

                            using (var xtr = XmlReader.Create(memStm, settings))
                            {
                                doc2.Load(xtr);

                            }
                        }
                        //string xmlResponse = ISO20022Utilities.SendRequest(doc2, PaymentStatusReportEndpoint1);
                        System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\paymentstatusreport(stima)\paymentstatusreport(stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", doc2.InnerXml);
                        string ipsresponse = null;
                        try
                        {
                            //sign Document before sending 
                            SignXMLFile(doc2, cert);

                            X509CertificateCollection clientCerts = new X509CertificateCollection();
                            clientCerts.Add(cert);

                            ServicePointManager.Expect100Continue = true;
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                            var client = new RestClient(PaymentStatusReportEndpoint1);
                            client.Timeout = -1;
                            client.ClientCertificates = clientCerts;
                            var request = new RestRequest(Method.POST);
                            request.AddHeader("Content-Type", "application/xml");
                            request.AddParameter("application/xml", doc2.OuterXml, ParameterType.RequestBody);
                            //request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                            IRestResponse Rejected = client.Execute(request);
                            ipsresponse = Rejected.Content;

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

                }
            }

            catch (Exception es)
            {
                res = new VerificationResponse
                {
                    message = "internal error occurred"
                };
            }

            return Accountno;

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