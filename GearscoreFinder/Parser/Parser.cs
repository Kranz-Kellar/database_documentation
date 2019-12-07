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
        static private string allodsArmoryAddress = $"http://armory.allodswiki.ru";

        static public void Init()
        {

        }

        static public string GetGearScoreOfPlayer(string characterName, string serverName)
        {
            string translitServer = TransliterationHandler.RussianToEnglish(serverName.ToLower().Trim());
            string translitName = TransliterationHandler.RussianToEnglish(characterName.ToLower().Trim());
            var pageOfArmoryAllods = LoadPage($"{allodsArmoryAddress}/avatar/{translitServer}/{translitName}".ToLower());
            var document = new HtmlDocument();
            document.LoadHtml(pageOfArmoryAllods);

            HtmlNodeCollection links = document.DocumentNode.SelectNodes(".//div[@class='font-weight-bold avatar-gearscore']");
            if(links == null)
            {
                return "Гирскор не найден";
            }
            return links[0].InnerText;
        }

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

        static public string FindElement(string XElement)
        {
            return "";
        }
    }
}
