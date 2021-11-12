using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using ISO20022Requests;
using ParticipantServer.ISO20022Request.CreditTransfer;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Reflection;

namespace IPSs.Controllers
{
    [Route("sync/v1/credit-transfer")]
    [ApiController]
    public class ISPCredittransferController : ControllerBase
    {
        [HttpPost]
        [Consumes("application/json")]
       public string ISPCreditTransfer([FromBody] IPSs.Models.ISO20022class.CreditTransferRequest credit)
        {
           
            string MsgId = credit.MessageID;
            string CdtrAcct = credit.DestinationAccountNo;
            string RemitterPhneNb = credit.SourcePhoneNo;
            string RemitterNm = credit.SourceAccountName;
            string Date = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
            string RemitterAcct = credit.SourceAccountNo;
            string PurposeiD = credit.Purpose;
            string Amount = credit.SourceAmount;
            string Purpose = credit.Purpose;
            string RemitterBackCode = "0089";
            string CdtrBankCode = credit.DestinationBankCode;
            //generate EndToEndId
            string EndToEndId = $"0089{CdtrBankCode}{DateTime.Now:yyyyMMddHHmmss}{RemitterAcct.Substring(0, 8)}";

          
            string CreditTransferSchemaPath = GetDLLPath() + @"\xsd\pacs.008.001.09.xsd"; ;
            string xmlns = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.09";
            string CreditTransferEndpoint = "https://api.stage.pesalink.co.ke/iso20022/async/v1/credit-transfer";
            string response = null;

            var xmlbody = new Document
            {
                FIToFICstmrCdtTrf = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrf
                {
                    GrpHdr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdr
                    {
                        CreDtTm = Date,
                        InstdAgt = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrInstdAgt
                        {
                            FinInstnId = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnId
                            {
                                Othr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrInstdAgtFinInstnIdOthr
                                {
                                    Id = "9999"
                                }
                            }
                        },
                        InstgAgt = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrInstgAgt
                        {
                            FinInstnId = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnId
                            {
                                Othr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrInstgAgtFinInstnIdOthr
                                {
                                    Id = "0089"
                                }
                            }
                        },
                        MsgId = MsgId,
                        NbOfTxs = "1",
                        PmtTpInf = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInf
                        {
                            CtgyPurp = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfCtgyPurp
                            {
                                Prtry = "IBNK"
                            },
                            LclInstrm = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfLclInstrm
                            {
                                Cd = "INST"
                            },
                            SvcLvl = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrPmtTpInfSvcLvl
                            {
                                Prtry = "P2PT"
                            }
                        },
                        SttlmInf = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrSttlmInf
                        {
                            ClrSys = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfGrpHdrSttlmInfClrSys
                            {
                                Prtry = "IPS"
                            },
                            SttlmMtd = "CLRG"
                        }

                    },
                    CdtTrfTxInf = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInf
                    {
                        AccptncDtTm = Date,

                        CdtrAcct = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcct
                        {
                            Id = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctID
                            {
                                Othr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAcctIDOthr
                                {
                                    Id = CdtrAcct
                                }
                            },

                        },
                        Cdtr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtr
                        {
                            Id = null
                        },
                        CdtrAgt = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgt
                        {
                            FinInstnId = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnId
                            {
                                Othr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfCdtrAgtFinInstnIdOthr
                                {
                                    Id =CdtrBankCode
                                }
                            }
                        },
                        ChrgBr = "SLEV",
                        Dbtr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtr
                        {
                            CtctDtls = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrCtctDtls
                            {
                                PhneNb = RemitterPhneNb
                            },

                            Nm =RemitterNm
                        },
                        DbtrAcct = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcct
                        {
                            Id = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctID
                            {
                                Othr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAcctIDOthr
                                {
                                    Id = RemitterAcct

                                }
                            }
                        },
                        DbtrAgt = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgt
                        {
                            FinInstnId = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnId
                            {
                                Othr = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfDbtrAgtFinInstnIdOthr
                                {
                                    Id = RemitterBackCode
                                }
                            }
                        },

                        IntrBkSttlmAmt = new DocumentFIToFICstmrCdtTrfCdtTrfTxInfIntrBkSttlmAmt
                        {
                            Ccy = "KES",
                            Value = Amount
                        },

                        PmtId = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfPmtId
                        {
                            EndToEndId = EndToEndId //"0089008920211022122653wsZKeN8Q"
                        },
                        Purp = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfPurp
                        {
                            Prtry = "001"
                        },
                        RmtInf = new ParticipantServer.ISO20022Request.CreditTransfer.DocumentFIToFICstmrCdtTrfCdtTrfTxInfRmtInf
                        {

                            Ustrd = Purpose
                        }


                    }
                }
            };

            //Write XML to file

            string dest = "CreditTransfer.xml";

            using (XmlWriter xmlWriter = XmlWriter.Create(dest))
            {

                XmlSerializer s = new XmlSerializer(xmlbody.GetType());
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                s.Serialize(xmlWriter, xmlbody, ns);

            }
            //compare generated XML against provided schema

            var schemas = new XmlSchemaSet();

            using (var schemaStream = System.IO.File.OpenRead(CreditTransferSchemaPath))
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
                        var serializerr = new XmlSerializer(typeof(Document));
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


                        var document = (Document)serializerr.Deserialize(xmlReader);

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

            string xmlResponse = ISO20022Utilities.SendRequest(doc, CreditTransferEndpoint);
            System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\OutgoingXml\credittransfer(stima)\credittransfer(stima)" + DateTime.Now.ToString("yyyyMMdd_hhmmss")+".xml", doc.InnerXml);

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
