using System;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....


            IDbFunktioner[] i = new IDbFunktioner[4];
            i[0] = new Hund();
            i[1] = new Ub�d();
            i[2] = new Ub�d();
            i[3] = new Hund();

            Ub�d u = new Ub�d();
            u = i[1] as Ub�d;
            u.Nummer = 10;
            
            foreach (IDbFunktioner item in i)
            {
                item.Gem();
                
            }
            


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }

    class Hund : Ting,IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine(("Gemmer hund"));
        }
    }

    class Ub�d : Ting,IDbFunktioner
    {
        public int Nr { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine(("Gemmer Ub�d"));
        }
    }

    class Ting {

        public int Nummer { get; set; }
    }

}
