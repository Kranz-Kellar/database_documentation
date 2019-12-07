using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearscoreFinder
{
    public class SessionHandler
    {
        static private string sessionFileName = "session.res";
        static public List<string> LoadLastSession()
        {
            if(!File.Exists(sessionFileName))
            {
                return new List<string>();
            }

            StreamReader file = new StreamReader(sessionFileName);
            string line = string.Empty;
            var result = new List<string>();
            while((line = file.ReadLine()) != null)
            {
                result.Add(line);
            }

            return result;
        }

        static public void SaveLastSession(List<string> sessionData)
        {

            File.Delete(sessionFileName);
            foreach(var data in sessionData)
            {
                File.AppendAllText(sessionFileName, $"{data}{Environment.NewLine}");
            }
        }
    }
}
