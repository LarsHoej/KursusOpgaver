using System;

namespace BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnArray(test);

            
            Console.WriteLine(res.sum.ToString());
            Console.WriteLine(res.gennemsnit.ToString());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static Arrayresult BeregnArray(int[] a)
        {

            Arrayresult result = new Arrayresult { gennemsnit=0,sum=0};
            
            for (int i = 0; i < a.Length; i++)
            {
                result.sum += a[i];
            }

            System.Array.Sort(a);
            result.gennemsnit = result.sum / a.Length;
            
            return result;

        }

        public struct Arrayresult
        {
            public double sum;
            public double gennemsnit;

        }
    }
}
