using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CharacterManager.Parser
{
    public class Parser
    {
        static private string allodsArmoryAddress = $"http://armory.allodswiki.ru/avatar";

        static private Dictionary<string, string> transliteration;
        static public void Init()
        {
            transliteration = new Dictionary<string, string>();
            transliteration.Add("а", "A");
            transliteration.Add("б", "B");
            transliteration.Add("в", "V");
            transliteration.Add("г", "G");
            transliteration.Add("д", "D");
            transliteration.Add("е", "E");
            transliteration.Add("ё", "E");
            transliteration.Add("ж", "ZH");
            transliteration.Add("з", "Z");
            transliteration.Add("и", "I");
            transliteration.Add("й", "Y");
            transliteration.Add("к", "K");
            transliteration.Add("л", "L");
            transliteration.Add("м", "M");
            transliteration.Add("н", "N");
            transliteration.Add("о", "O");
            transliteration.Add("п", "P");
            transliteration.Add("р", "R");
            transliteration.Add("с", "S");
            transliteration.Add("т", "T");
            transliteration.Add("у", "U");
            transliteration.Add("ф", "F");
            transliteration.Add("х", "KH");
            transliteration.Add("ц", "CE");
            transliteration.Add("ч", "CH");
            transliteration.Add("ш", "SH");
            transliteration.Add("щ", "SHCH");
            transliteration.Add("ъ", "_");
            transliteration.Add("ы", "YI");
            transliteration.Add("ь", "-");
            transliteration.Add("э", "EH");
            transliteration.Add("ю", "YU");
            transliteration.Add("я", "YA");
            transliteration.Add(" ", "-");
        }

        static public string GetGearScoreOfPlayer(string characterName, string serverName)
        {
            string translitServer = TranslitToEnglish(serverName.ToLower().Trim());
            string translitName = TranslitToEnglish(characterName.ToLower().Trim());
            var pageOfArmoryAllods = LoadPage($"{allodsArmoryAddress}/{translitServer}/{translitName}".ToLower());
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

        static private string TranslitToEnglish(string word)
        {
            StringBuilder ret = new StringBuilder();

            for(int i = 0; i < word.Length; i++)
            {
                var wordChar = word.Substring(i, 1);
                var character = transliteration[wordChar];
                ret.Append(character);
            }

            return ret.ToString();
        }
    }
}
