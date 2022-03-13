using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(DateTime.Now + ";"
+ LoginValidation.currentUserName + ";"
+ LoginValidation.currentUserRole + ";"
+ activity + "\n");

            currentSessionActivities.Add(stringBuilder.ToString());
            if (File.Exists("Logs.txt") == true)
            {
                File.AppendAllText("Logs.txt", currentSessionActivities.ToString());
            }
        }
        static public IEnumerable<string> GetCurrentSessionActivities()
        {
            return currentSessionActivities;
        }

    }
}