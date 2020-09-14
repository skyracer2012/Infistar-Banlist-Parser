using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infistar_Download
{
    class InfiHelper
    {

        public List<string> downloadStreamManager(Stream streamResponse)
        {
            string data = "";
            StreamReader streamRead = new StreamReader(streamResponse);
            Char[] readBuff = new Char[256];
            int count = streamRead.Read(readBuff, 0, 256);
            while (count > 0)
            {
                string outputData = new string(readBuff, 0, count);
                data += (outputData);
                count = streamRead.Read(readBuff, 0, 256);
            }
            streamRead.Close();
            streamResponse.Close();
            data = data.Replace("\nend\n", "");
            return data.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        public List<string> recieveData()
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://armalog.infistar.de/bans.txt");
            myHttpWebRequest.UserAgent = "infiSTAR DLL"; //From decompiled dll 2018
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            List<string> data = downloadStreamManager(myHttpWebResponse.GetResponseStream());

            myHttpWebResponse.Close();

            return data;
        }
    }
}
