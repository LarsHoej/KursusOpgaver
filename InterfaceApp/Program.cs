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
            i[1] = new Ubåd();
            i[2] = new Ubåd();
            i[3] = new Hund();

            Ubåd u = new Ubåd();
            u = i[1] as Ubåd;
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

    class Ubåd : Ting,IDbFunktioner
    {
        public int Nr { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine(("Gemmer Ubåd"));
        }
    }

    class Ting {

        public int Nummer { get; set; }
    }

}
