using ISO20022Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IPSs
{
    public class WebService
    {
        public static WebRef.PESALinkTransfer_PortClient BC
        {

            get
            {
                string user = "agencybanking";
                string pwd = "B@nking324..";
                string domain = "stima-sacco";
                string serverUrl = "http://navtest.stima-sacco.local:2022/NAVTEST/WS/STIMASACCO/Codeunit/PESALinkTransfer";

                var ws = new WebRef.PESALinkTransfer_PortClient();

                try
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    var credentials = new NetworkCredential(user, pwd, domain);
                    //  ws.UseDefaultCredentials = true;
                    ws.serviceEndpoint = string.Format(serverUrl);
                    ws.PreAuthenticate = true;
                    ws.clientCredentials = credentials;
                }
                catch (Exception ex)
                {
                    ex.Data.Clear();
                    Logs.WriteLog("Base: " + ex.Message);
                }
                return ws;
            }
        }
    }
}
