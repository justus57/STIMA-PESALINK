using IPSs.Models.ISO20022class;
using ISO20022Requests;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ParticipantServer.Controllers
{
    [ApiController]
    [Route("v1/payment-status-report")]
    public class PaymentStatusReportController :ControllerBase
    {
        [HttpPost]
        [Consumes("application/xml")]
        public async Task PaymentStatusReport()
        {
            try
            {
                string content = "";
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    content = await reader.ReadToEndAsync();
                }
                System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\Incomingxml\paymentstatusreport(IPS)\paymentstatusreport(IPS)" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", content);

                var serializer = new XmlSerializer(typeof(ISO20022Request.PaymentStatusReport.Document));
                ISO20022Request.PaymentStatusReport.Document report;


                using (TextReader reader = new StringReader(content))
                {
                    report = (ISO20022Request.PaymentStatusReport.Document)serializer.Deserialize(reader);
                }
                string MsgId = report.FIToFIPmtStsRpt.GrpHdr.MsgId;
                var IntrBkSttlmAmt = report.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.IntrBkSttlmAmt.Value;
                string RemitterAcct = report.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.DbtrAcct.Id.Othr.Id;
                var RemitterBankcode = report.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.DbtrAgt.FinInstnId.Othr.Id;
                string BeneficaryNm = report.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.Cdtr.Pty.Nm;
                string BeneficiaryAccount = report.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.CdtrAcct.Id.Othr.Id; 
                var BeneficaryBankCode = report.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.CdtrAgt.FinInstnId.Othr.Id;
                string RemitterNm = report.FIToFIPmtStsRpt.TxInfAndSts.OrgnlTxRef.Dbtr.Pty.Nm;
                string OrgnlMsgId = report.FIToFIPmtStsRpt.OrgnlGrpInfAndSts.OrgnlMsgId;
                var TxSts = report.FIToFIPmtStsRpt.TxInfAndSts.TxSts;
                try
                {
                    if (TxSts != "ACCP")
                    {
                        var Reason4Rjct = report.FIToFIPmtStsRpt.TxInfAndSts.StsRsnInf.Rsn.Cd;
                        if (RemitterBankcode == "0089")
                        {
                            int position = OrgnlMsgId.IndexOf('-');
                            OrgnlMsgId = OrgnlMsgId.Substring(0, position);

                            string xmlreq = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                                <Body>
                                    <UpdateTransferStatus xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                        <requestID>" + OrgnlMsgId + @"</requestID>
                                        <statusOfRequestCode>" + Reason4Rjct + @"</statusOfRequestCode>
                                    </UpdateTransferStatus>
                                </Body>
                            </Envelope>";

                            string response = trial.Utility.CallWebService(xmlreq);

                            response = trial.Utility.GetJSONResponse(response);

                            Logs.WriteLog(response);
                        }
                        else
                        {
                            //rejct of inbound

                            string xmlreq1 = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                                        <Body>
                                            <UpdateDepositStatus xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                                <entryNo>" + "" + @"</entryNo>
                                                <sourceReferenceNo>" + OrgnlMsgId + @"</sourceReferenceNo>
                                                <sourceBankCode>" + RemitterBankcode + @"</sourceBankCode>
                                                <sourceAccountNo>" + RemitterAcct + @"+</sourceAccountNo>
                                                <amountToTransfer>" + IntrBkSttlmAmt + @"</amountToTransfer>
                                                <destinationAccountNo>" + BeneficiaryAccount + @"</destinationAccountNo>
                                                <responseCode>" + Reason4Rjct + @"</responseCode>
                                            </UpdateDepositStatus>
                                        </Body>
                                    </Envelope>";
                            string responses = trial.Utility.CallWebService(xmlreq1);

                            responses = trial.Utility.GetJSONResponse(responses);

                            Logs.WriteLog(responses);
                        }



                    }
                    else //if accepted 
                    {
                        
                            if (RemitterBankcode == "0089")
                            {
                                int position = OrgnlMsgId.IndexOf('-');
                                OrgnlMsgId = OrgnlMsgId.Substring(0, position);

                                string xmlreq = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                                            <Body>
                                                <UpdateTransferStatus xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                                    <requestID>" + OrgnlMsgId + @"</requestID>
                                                    <statusOfRequestCode>" + TxSts + @"</statusOfRequestCode>
                                                </UpdateTransferStatus>
                                            </Body>
                                        </Envelope>";

                                string response = trial.Utility.CallWebService(xmlreq);

                                response = trial.Utility.GetJSONResponse(response);

                                Logs.WriteLog(response);
                        }
                        else
                        {

                            string xmlreq1 = @"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"">
                                        <Body>
                                            <UpdateDepositStatus xmlns=""urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer"">
                                                <entryNo>" + "" + @"</entryNo>
                                                <sourceReferenceNo>" + OrgnlMsgId + @"</sourceReferenceNo>
                                                <sourceBankCode>" + RemitterBankcode + @"</sourceBankCode>
                                                <sourceAccountNo>" + RemitterAcct + @"+</sourceAccountNo>
                                                <amountToTransfer>" + IntrBkSttlmAmt + @"</amountToTransfer>
                                                <destinationAccountNo>" + BeneficiaryAccount + @"</destinationAccountNo>
                                                <responseCode>" + TxSts + @"</responseCode>
                                            </UpdateDepositStatus>
                                        </Body>
                                    </Envelope>";
                            string responses = trial.Utility.CallWebService(xmlreq1);

                            responses = trial.Utility.GetJSONResponse(responses);

                            Logs.WriteLog(responses);
                        }
                    }

                }
                catch(Exception es)
                {
                    Logs.WriteLog(es.Message);
                }  
                var Result = IPSs.WebService.BC.PostPESALinkDepositsAsync();
            }
            catch (Exception es)
            {
                Logs.WriteLog(es.Message);
            }
        }

    }
}