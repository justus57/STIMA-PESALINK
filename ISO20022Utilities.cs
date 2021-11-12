using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using System.Security.Cryptography;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

using System.Security.Cryptography.Xml;
using System.Web;
using RestSharp;

namespace ISO20022Requests
{
    public class ISO20022Utilities
    {
        static string certPath = "cert/bank0089_transport.cert.pfx";
       // X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(folderPath + "bank0089_transport.cert.pfx"), ""); //path to certificate

        static X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(certPath), ""); //path to certificate
        public  static string SendRequest(XmlDocument doc, string url)
        {
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

                var client = new RestClient(url);
                client.Timeout = -1;
                client.ClientCertificates = clientCerts;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/xml");
                 request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                //request.AddParameter("application/xml", doc.OuterXml, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                ipsresponse = response.Content;

               // Console.WriteLine(ipsresponse);
            }
            catch(Exception es)
            {
              Logs.WriteLog(es.Message);
                string innerEx = "";
                if (es.InnerException != null)
                    innerEx = es.InnerException.ToString();
            }
            return ipsresponse;
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
