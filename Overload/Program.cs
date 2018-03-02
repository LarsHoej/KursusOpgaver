using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1, 2,3));
            Console.WriteLine(Beregn(1, 2,4,5));

            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static int Beregn(int a, int b, int c)
        {
            return Beregn(a,b,c,0);
        }

        static int Beregn(int a, int b)
        {
            return Beregn(a, b, 0, 0);
        }


    }
}
