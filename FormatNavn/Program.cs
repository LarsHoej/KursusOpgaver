using System;

namespace FormatNavn
{

    public static class MyString
    {

        public static string Formatnavn(this string navn)
        {
            return navn.Substring(0,1).ToUpper() +  navn.ToLower().Substring(1);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            string navn = "lars";
            
            Console.WriteLine(navn.Formatnavn());

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
