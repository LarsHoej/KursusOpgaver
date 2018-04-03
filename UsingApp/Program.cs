using System;
using System.IO;

namespace UsingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // Your code here.....
            using (StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {                    
                    Console.WriteLine(stream.ReadLine());
                }
            }



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
