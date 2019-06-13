using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Authentication;
using System.Net;
using System.IO;
using System.Web;
using System.Net.Sockets;
using System.Net.Mail;


namespace EmployeeManagementApp.Loader
{
    public class WebLoader
    {
        private string _url;
        private string[] lines;
        private string html = string.Empty;

        public string[] Lines
        {
            get
            {
                return lines;
            }
        }

        public WebLoader(string url)
        {
            _url = url;
            const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
            const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
            ServicePointManager.SecurityProtocol = Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            lines = html.Split('\n');

        }

        public void Loader()
        {




            //    employeelistDataParser = _parser.GenerateEmployeeList(lines);
            //}
            //// return employeelistDataParser;
            //public Dictionary<Employee, Employee> GetEmployeeList()
            //{
            //    return _parser.GenerateEmployeeList(lines);
            //}


        }
    }
}





