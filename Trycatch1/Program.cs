using System;

namespace Trycatch1
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("der er sket en fejl " +  ex.Message);                
            }
            


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal : ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast 2. tal : ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int res = tal1 + tal2;
            Console.WriteLine("Resultat er " + res);


        }
    }
}
