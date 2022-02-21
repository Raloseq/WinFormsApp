using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;

namespace WcfServiceSzpital
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {       
        string path = @"C:\Users\User\Desktop\Pracownicy.txt";
        public void SaveEmployeeToFile(string employee)
        { 
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(employee);
            }

        }

        public void DeleteEmployeeFromFile(string employee)
        {
            string item = employee;
            var lines = File.ReadAllLines(path).Where(line => line != item).ToArray();
            File.WriteAllLines(path, lines);
        }

        public void UpdateEmployeeInFile(string employee, string updated)
        {
            string[] file = File.ReadAllLines(path);
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Trim() == employee.Trim())
                {
                    file[i] = updated;
                }
            }
            File.WriteAllLines(path, file);


        }

        public string Backup()
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(
                new Uri(string.Format("{0}/{1}", ConfigurationManager.AppSettings["url"],"Pracownicy.txt"))
                );
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["ftp-login"], ConfigurationManager.AppSettings["ftp-pass"]);

            using (FileStream fileStream = new FileStream(path,FileMode.Open,FileAccess.Read))
            using (Stream reqStream = request.GetRequestStream())
            {
                fileStream.CopyTo(reqStream);
            }

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            return $"Wysłano plik z pracownikami na serwer ftp: {response.StatusDescription}";
        }
    }
}
