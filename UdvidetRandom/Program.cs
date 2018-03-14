using System;

namespace UdvidetRandom
{
    public class MinRandom : System.Random
    {


        public bool NextBool()
        {
            return this.Next(1, 1002) < 500;            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            MinRandom r = new MinRandom();
            Console.WriteLine(r.NextBool());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
