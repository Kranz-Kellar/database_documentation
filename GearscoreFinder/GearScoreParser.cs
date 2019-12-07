using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    public class GearScoreParser
    {
        static private string allodsArmoryAddress = $"http://armory.allodswiki.ru";
        static private string XPathToGearscore = ".//div[@class='font-weight-bold avatar-gearscore']";
        static private string XPathToAvailableServers = ".//select[@id='serverName']/option";
        static public string GetGearScoreOfPlayer(string characterName, string serverName)
        {
            string translitServer = TransliterationHandler.RussianToEnglish(serverName.ToLower().Trim());
            string translitName = TransliterationHandler.RussianToEnglish(characterName.ToLower().Trim());
            var pageOfArmoryAllodsAddressWithPlayerInfo = $"{allodsArmoryAddress}/avatar/{translitServer}/{translitName}".ToLower();
            string gearscore = Parser.FindElement(pageOfArmoryAllodsAddressWithPlayerInfo, XPathToGearscore);
            return gearscore;
        }

        static public List<string> GetAvailableServers()
        {
            var serverList = Parser.FindListOfElements(allodsArmoryAddress, XPathToAvailableServers);
            DeleteFirstElementFromServerList(serverList);
            return serverList;
        }

        static private void DeleteFirstElementFromServerList(List<string> serverList)
        {
            serverList.RemoveAt(0);
        }
    }
}
