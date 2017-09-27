using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using ScheduleScraper.Models;


namespace ScheduleScraper
{
    public static class Scraper
    {
        static Uri URL = new Uri("https://spaceflightnow.com/");
        const string relative = "launch-schedule/";

        private static HtmlDocument GetDocument(Uri uri)
        {
            HtmlDocument output = null;
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            HttpStatusCode status = response.StatusCode;
            if (status == HttpStatusCode.OK)
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = null;
                if (response.CharacterSet == null)
                {
                    reader = new StreamReader(stream);
                }
                else
                {
                    reader = new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet));
                }
                string page = reader.ReadToEnd();
                output = new HtmlDocument();
                output.LoadHtml(page);
                return output;
            }
            else
            {
                return output;
            }
        }
        public static List<ScheduleModel> GetSchedule()
        {
            List<ScheduleModel> Schedule = null;
            Uri ScheduleUri = new Uri(URL, relative);
            HtmlDocument doc = GetDocument(ScheduleUri);
            //string xPathDate = "/div/table/tbody/tr[]/td[2]/div/div[1]/img",
            //    xPathLocation = "/div/div[3]",
            //    xPathModel = "/div/table/tbody/tr[]/td[5]/div/div/div[1]/span[2]/time";
            //int xPathIndex = 1;

            if (doc != null)
            {
                Schedule = new List<ScheduleModel>();
                HtmlNodeCollection nodeList = doc.DocumentNode.SelectNodes("//*[@id='page-64']/div/div");
            }
            return Schedule;
        }
        /*
        public static string GetList(HtmlDocument doc, string xPath)
        {
            HtmlNodeCollection weatherNodes = doc.DocumentNode.SelectNodes(xPath);
            switch (xPath.Substring((xPath.Length - 2), (xPath.Length - 1)))
            {
                case "g":
                        
                    break;
                
            }
        }
        */
    }
}