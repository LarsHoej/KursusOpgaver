using System;

namespace SwapType
{

    
    class Program
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {


            // Your code here.....

            string a = "10";
            string b = "20";

            Swap(ref a, ref b);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
