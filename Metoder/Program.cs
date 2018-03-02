using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            int res = L�gSammen(5, 2);
            Console.WriteLine(res.ToString());

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2.ToString());

            Udskriv();
            Udskriv("ikke blank");

            double res3 = BeregnMoms(100.35,0.10);
            Console.WriteLine(res3.ToString());

            int[] l�n = { 10000, 5000, 30000 };
            double gns = Gennemsnit(l�n);
            Console.WriteLine(gns.ToString());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static int L�gSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }

        static void Udskriv(string txt = "")
        {
            Console.WriteLine(txt);

        }

        static double BeregnMoms(double bel�b, double momspct = 0.25)
        {
            return bel�b * momspct;

        }

        static double Gennemsnit(int[] a)
        {
            double gns = 0;
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            gns = sum / a.Length;

            return gns;
        }


    }
}
