using System;

namespace ArealBeregnerConsole
{

    static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double brede)
        {
            return højde * brede;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return Math.Pow(radius,2) * System.Math.PI;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10,10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
