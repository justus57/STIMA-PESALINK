using IPSs.Models.ISO20022class;
using ISO20022Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParticipantServer.Controllers
{
    [ApiController]
    [Route("v1/message-reject")]
    public class MessageRejectController :ControllerBase
    {
        [HttpPost]
        [Consumes("application/xml")]
        public async Task Messagereject()
        {
            try
            {
                string content = "";
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    content = await reader.ReadToEndAsync();
                }
                System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\Incomingxml)\Messagereject(ips)\messagerejectIso20022" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", content);

                var serializer = new XmlSerializer(typeof(ISO20022Request.MessageReject.Document));
                ISO20022Request.MessageReject.Document reject;


                using (TextReader reader = new StringReader(content))
                {
                    reject = (ISO20022Request.MessageReject.Document)serializer.Deserialize(reader);
                }

                var Ref= reject.admi00200101.RltdRef.Ref;
                var status = reject.admi00200101.Rsn.RjctgPtyRsn;
                var Dateofreject = reject.admi00200101.Rsn.RjctnDtTm;


                var Responses = IPSs.WebService.BC.UpdateTransferStatusAsync(Ref, Dateofreject);
                Logs.WriteLog(status);
                //System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\Messagereject(ips)\messagerejectIso20022" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", content);




            }
            catch (Exception es) 
            { 
                Logs.WriteLog(es.Message);
            }
             //Logs.WriteLog(RjctgPtyRsn);
            //System.IO.File.WriteAllText(@"C:\Logs\Pesalinkrequestandreposnses(xml)\Messagereject(ips)\messagerejectIso20022" + DateTime.Now.ToString("yyyyMMdd_hhmmss")+".xml");

            //return RsnDesc;
        }
        
    }
}