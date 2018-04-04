using System;

namespace OperatorOverload
{
    public class Hund
    {
        public string Navn { get; set; }
        public int LydNiveau { get; set; }

        public static bool operator >(Hund h1, Hund h2)
        {
            return h1.LydNiveau > h2.LydNiveau;
        }

        public static bool operator <(Hund h1, Hund h2)
        {
            return h1.LydNiveau < h2.LydNiveau;
        }

                
    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Hund h1 = new Hund() { Navn = "A", LydNiveau = 30 };
            Hund h2 = new Hund() { Navn = "B", LydNiveau = 20 };

            Console.WriteLine(h1 < h2);
            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
