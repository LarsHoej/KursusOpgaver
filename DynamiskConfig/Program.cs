using System;

namespace DynamiskConfig
{
    class Program
    {

        static string GetAppSetting(string key, string defaultvalue)
        {
            string s = System.Configuration.ConfigurationManager.AppSettings[key];
            if (s == null)
            {
                return defaultvalue;
            }
            else return s;

        }
        static T GetAppSettingGeneric<T>(string key, T defaultvalue)
        {
            string s = System.Configuration.ConfigurationManager.AppSettings[key];
            if (s == null)
            {
                return defaultvalue;
            }
            else return (T)Convert.ChangeType(s, typeof(T));

        }

            static void Main(string[] args)
        {


            // Your code here.....


            string ip = GetAppSetting("ip", "127.0.0.1");
            int maxRecords = GetAppSettingGeneric("maxRecords",100);

            Console.WriteLine(ip);
            Console.WriteLine(maxRecords);


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
