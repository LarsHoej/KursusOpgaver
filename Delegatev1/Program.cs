using System;

namespace Delegatev1
{
    class Program
    {

        public delegate int beregnmetode(int a, int b);

        public static int Plus(int a, int b)
        {
            return a + b;
        }


        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static int Beregner(int a, int b, beregnmetode metode)
        {
            return metode(a, b);
        }

        static void Main(string[] args)
        {


            // Your code here.....


            int res = Beregner(10, 10, Plus);


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
