using System;

namespace Delegatev2
{
    class Program
    {


        public delegate int beregnmetode(int a, int b);

        public static double Plus(double a, double b)
        {
            return a + b;
        }


        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Divider(double a, double b)
        {
            return a / b;
        }

        public static double Gange(double a, double b)
        {
            return a * b;
        }

        public static double Procent(double a, double b)
        {
            return (a / b) * 100;
        }


        public static double Beregner(double a, double b, Func<double, double, double> metode) => metode(a, b);


        public static Func<double, double, double> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;

            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;

            if (System.DateTime.Now.Millisecond <= 750)
                return Divider;


            return Gange;
        }
        
            static void Main(string[] args)
        {




             // Your code here.....
            double res = 0;

            res = Beregner(30, 100, Procent);
            Console.WriteLine(res);

            res = Beregner(1, 1, Plus);
            res = Beregner(1, 1, Minus);

            Console.WriteLine(res);

            res = Beregner(1, 1, Gange);
            Console.WriteLine(res);

            res = Beregner(10, 10, FindTilfældigFunktion());
            Console.WriteLine(res);

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
