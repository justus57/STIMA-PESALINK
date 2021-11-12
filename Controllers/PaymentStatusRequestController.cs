using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ParticipantServer.Controllers
{
    [ApiController]
    [Route("v1/payment-status-request")]
   
    public class PaymentStatusRequestController:ControllerBase
    {
        [Consumes("application/xml")]
        public async Task Post()
        {

            try
            {
                string content = "";
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    content = await reader.ReadToEndAsync();
                }
                System.IO.File.WriteAllText(@"C:\Logs\New folder\paymentstatusreportIso20022", content);

            }
            catch
            {

            }
          //  // Reading data as XML string to log to files - In case message structure is changed
          //  var xmlDocP = new XmlDocument();
          ////  xmlDocP.Load(request.Content.ReadAsStreamAsync().Result);
          //  var str = xmlDocP.InnerXml;

          //  //XDocument doc = new XDocument();

          //  //XmlSerializer serializer;

          //  //serializer = new XmlSerializer(typeof(ParticipantServer.ISO20022Request.PaymentStatusRequest.Document));
          //  //StringReader rdr = new StringReader(str);
          //  //ParticipantServer.ISO20022Request.PaymentStatusRequest.Document paymentstatusrequestrequestBody = (ParticipantServer.ISO20022Request.PaymentStatusRequest.Document)serializer.Deserialize(rdr);



          //  //string MsgId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.GrpHdr.MsgId;
          //  //var CreDtTm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.GrpHdr.CreDtTm;
          //  //var InstgAgtId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.GrpHdr.InstgAgt.FinInstnId.Othr.Id;
          //  //var InstdAgtId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.GrpHdr.InstdAgt.FinInstnId.Othr.Id;
          //  //string OrgnlMsgId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.OrgnlGrpInf.OrgnlMsgId;
          //  //var OrgnlMsgNmId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.OrgnlGrpInf.OrgnlMsgNmId;
          //  //var OrgnlCreDtTm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.OrgnlGrpInf.OrgnlCreDtTm;
          //  //string StsReqId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.StsReqId;
          //  //var OrgnlEndToEndId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlEndToEndId;
          //  //var AccptncDtTm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.AccptncDtTm;
          //  //var IntrBkSttlmAm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.IntrBkSttlmAmt;
          //  //var DtTm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.ReqdExctnDt.DtTm;
          //  //var SttlmMtd = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.SttlmInf.SttlmMtd;
          //  //var ClrSysPrtry = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.SttlmInf.ClrSys.Prtry;
          //  //var SvcLvlPrtry = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.PmtTpInf.SvcLvl.Prtry;
          //  //var LclInstrmCd = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.PmtTpInf.LclInstrm.Cd;
          //  //var CtgyPurpPrtry = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.PmtTpInf.CtgyPurp.Prtry;
          //  //string MndtId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.MndtRltdInf.CdtTrfMndt.MndtId;
          //  //string Ustrd = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.RmtInf.Ustrd;
          //  //string StrdRef = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.RmtInf.Strd.CdtrRefInf.Ref;
          //  //string UltmtDbtrNm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.UltmtDbtr.Pty.Nm;
          //  //var UltmtDbtrId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.UltmtDbtr.Pty.Id.OrgId.Othr.Id;
          //  //string UltmtDbtrPheNb = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.UltmtDbtr.Pty.CtctDtls.PhneNb;
          //  //string DbtrNm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.Dbtr.Pty.Nm;
          //  //var DbtrId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.Dbtr.Pty.Id.OrgId.Othr.Id;
          //  //string DbtrPhneNb = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.Dbtr.Pty.CtctDtls.PhneNb;
          //  //var DbtrAcctId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.DbtrAcct.Id.Othr.Id;
          //  //var DbtrAcctPrtry = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.DbtrAcct.Id.Othr.SchmeNm.Prtry;
          //  //string DbtrAcctNm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.DbtrAcct.Nm;
          //  //var DbtrAgtId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.DbtrAgt.FinInstnId.Othr.Id;
          //  //var CdtrAgtId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.CdtrAgt.FinInstnId.Othr.Id;
          //  //string CdtrNm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.Cdtr.Pty.Nm;
          //  //var CdtrId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.Cdtr.Pty.Id.OrgId.Othr.Id;
          //  //var CdtrPhneNb = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.Cdtr.Pty.CtctDtls.PhneNb;
          //  //string CdtrAcctId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.CdtrAcct.Id.Othr.Id;
          //  //var CdtrAcctPrtry = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.CdtrAcct.Id.Othr.SchmeNm.Prtry;
          //  //string CdtrAcctNm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.CdtrAcct.Nm;
          //  //string UltmtCdtrNm = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.UltmtCdtr.Pty.Nm;
          //  //var UltmtCdtrId = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.UltmtCdtr.Pty.Id.OrgId.Othr.Id;
          //  //string UltmtCdtrPhneNb = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.UltmtCdtr.Pty.CtctDtls.PhneNb;
          //  //string PurpPrtry = paymentstatusrequestrequestBody.FIToFIPmtStsReq.TxInf.OrgnlTxRef.Purp.Prtry;
          //  string path = @"C:\Logs\New folder\paymentstatusrequesttIso20022";

          //  if (!File.Exists(path))
          //  {
          //      File.Create(path).Dispose();

          //      using (TextWriter tw = new StreamWriter(path))
          //      {
          //          tw.WriteLine(xmlDocP.InnerXml);
          //      }

          //  }
          //  else if (File.Exists(path))
          //  {
          //      using (StreamWriter w = File.AppendText(path))
          //      {
          //          w.WriteLine(xmlDocP.InnerXml);
          //          w.Close();
          //      }
          //  }
          //  //File.WriteAllText(@"C:\Logs\New folder\paymentstatusrequesttIso20022", xmlDocP.InnerXml);
          //  return new HttpResponseMessage
          //  {
          //      Content = new StringContent(xmlDocP.InnerXml, Encoding.UTF8, "application/xml")

          //  };
        }
    }
}