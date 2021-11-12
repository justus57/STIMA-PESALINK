using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ISO20022Requests
{
    public class Logs
    {
        public static void WriteLog(string text)
        {
            try
            {
                //set up a filestream
                string strPath = @"C:\Logs\Pesalinkrequestandreposnses(xml)\testISO20022";
                string fileName = DateTime.Now.ToString("MMddyyyy") + "_logs.txt";
                string filenamePath = strPath + '\\' + fileName;
                Directory.CreateDirectory(strPath);
                FileStream fs = new FileStream(filenamePath, FileMode.OpenOrCreate, FileAccess.Write);
                //set up a streamwriter for adding text
                StreamWriter sw = new StreamWriter(fs);
                //find the end of the underlying filestream
                sw.BaseStream.Seek(0, SeekOrigin.End);
                //add the text
                sw.WriteLine(DateTime.Now.ToString() + ": " + text);
                //add the text to the underlying filestream
                sw.Flush();
                //close the writer
                sw.Close();
            }
            catch (Exception ex)
            {
                //throw;
                ex.Data.Clear();
            }
        }
    }
}
