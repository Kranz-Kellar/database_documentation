using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    public class TransliterationHandler
    {
        static private Dictionary<string, string> transliterationDict;
        static public void Init()
        {
            transliterationDict = new Dictionary<string, string>();
            transliterationDict.Add("а", "A");
            transliterationDict.Add("б", "B");
            transliterationDict.Add("в", "V");
            transliterationDict.Add("г", "G");
            transliterationDict.Add("д", "D");
            transliterationDict.Add("е", "E");
            transliterationDict.Add("ё", "E");
            transliterationDict.Add("ж", "ZH");
            transliterationDict.Add("з", "Z");
            transliterationDict.Add("и", "I");
            transliterationDict.Add("й", "Y");
            transliterationDict.Add("к", "K");
            transliterationDict.Add("л", "L");
            transliterationDict.Add("м", "M");
            transliterationDict.Add("н", "N");
            transliterationDict.Add("о", "O");
            transliterationDict.Add("п", "P");
            transliterationDict.Add("р", "R");
            transliterationDict.Add("с", "S");
            transliterationDict.Add("т", "T");
            transliterationDict.Add("у", "U");
            transliterationDict.Add("ф", "F");
            transliterationDict.Add("х", "KH");
            transliterationDict.Add("ц", "CE");
            transliterationDict.Add("ч", "CH");
            transliterationDict.Add("ш", "SH");
            transliterationDict.Add("щ", "SHCH");
            transliterationDict.Add("ъ", "_");
            transliterationDict.Add("ы", "YI");
            transliterationDict.Add("ь", "-");
            transliterationDict.Add("э", "EH");
            transliterationDict.Add("ю", "YU");
            transliterationDict.Add("я", "YA");
            transliterationDict.Add(" ", "-");
        }

        static public string RussianToEnglish(string word)
        {
            StringBuilder ret = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                var wordChar = word.Substring(i, 1);
                var character = transliterationDict[wordChar];
                ret.Append(character);
            }

            return ret.ToString();
        }
    }
}
