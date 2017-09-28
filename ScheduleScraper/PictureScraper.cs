using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace ScheduleScraper
{
    class PictureScraper
    {
        static Uri URL = new Uri("https://en.wikipedia.com/wiki/");

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
        public static List<string> GetImage(string relativePath)
        {
            List<string> source = null;
            Uri PictureUri = new Uri(URL, relativePath);
            HtmlDocument doc = GetDocument(PictureUri);
            if (doc != null)
            {
                source = new List<string>();
                HtmlNodeCollection nodeList = doc.DocumentNode.SelectNodes("/div/table[1]/tbody/tr[1]/td/a/img");
                foreach (HtmlNode thisNode in nodeList)
                {
                    source.Add(thisNode.Attributes["src"].Value);
                }
            }
            return source;
        }
        public static string CreateRealtivePath(string rocketModel)
        {
            if (rocketModel.Contains("Proton"))
            {
                rocketModel = "Proton_(rocket_family)";
            }
            else if (rocketModel.Contains(' ') && rocketModel.Contains("Proton"))
            {
                rocketModel.Replace(' ', '_');
            }
            return rocketModel;
        }
    }
}