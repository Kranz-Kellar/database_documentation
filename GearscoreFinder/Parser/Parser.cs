using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CharacterManager
{
    public class Parser
    {

        static private string LoadPage(string url)
        {

            var result = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var receiveStream = response.GetResponseStream();
                if (receiveStream != null)
                {
                    StreamReader readStream;
                    if (response.CharacterSet == null)
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    result = readStream.ReadToEnd();
                    readStream.Close();
                }
                response.Close();
            }
            return result;
        }

        static public string FindElement(string page, string XPath)
        {
            var pageOfArmoryAllods = LoadPage(page.ToLower());
            var document = new HtmlDocument();
            document.LoadHtml(pageOfArmoryAllods);

            HtmlNodeCollection items = document.DocumentNode.SelectNodes(XPath);
            if (items == null)
            {
                return "Элемент не найден.";
            }
            return items[0].InnerText;
        }

        static public List<string> FindListOfElements(string page, string XPath)
        {
            var pageOfArmoryAllods = LoadPage(page.ToLower());
            var document = new HtmlDocument();
            document.LoadHtml(pageOfArmoryAllods);

            HtmlNodeCollection items = document.DocumentNode.SelectNodes(XPath);
            if (items == null)
            {
                throw new Exception($"Page {page} with XPath {XPath} not found");
            }
            var result = new List<string>();
            foreach(var item in items)
            {
                result.Add(item.InnerText);
            }

            return result;
        }
    }
}
