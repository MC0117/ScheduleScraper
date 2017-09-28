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
            if (doc != null)
            {
                Schedule = new List<ScheduleModel>();

                HtmlNodeCollection nodeList = doc.DocumentNode.SelectNodes("//*[@id='page-64']/div/div");

                for (int i = 0; i < nodeList.Count; i += 3)
                {
                    List<string> img = new List<string>();
                    HtmlNode launchDateNode = nodeList[i];
                    string date = (launchDateNode.ChildNodes.Where(n => n.Name == "span").First().InnerText);
                    string modelCargo = (launchDateNode.ChildNodes.Where(n => n.Name == "span").Last().InnerText);

                    HtmlNode missionDataNode = nodeList[i + 1];
                    string location = missionDataNode.ChildNodes[3].InnerText;

                    HtmlNode missionDescriptionNode = nodeList[i + 2];
                    string updateDescription = missionDescriptionNode.ChildNodes[0].InnerText;

                    string imagePath = PictureScraper.CreateRealtivePath(modelCargo.Split('•').First());
                    List<string> images = PictureScraper.GetImage(imagePath);
                    string imgUrl = null;
                    if (images != null && images.Count > 0)
                    {
                        img.Add(images[0]);
                    }
                    ScheduleModel launch = new ScheduleModel(modelCargo.Split('•').First(), modelCargo.Split('•').Last().Remove(0, 1), date, location, updateDescription.Split('[').First(), imgUrl);
                    Schedule.Add(launch);
                    //img.add(PictureimagePath)
                }
            }
            return Schedule;
        }
    }
}