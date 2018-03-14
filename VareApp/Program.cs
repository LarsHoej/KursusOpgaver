using System;

namespace VareApp
{

    class Vare
    {
        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("getNavn");
                return navn;
            }
            set
            {
                Console.WriteLine("setNavn");
                navn = value;
            }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("getPris");
                return pris;
            }
            set
            {
                Console.WriteLine("setPris");
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return Pris * 1.25;
        }

        public Vare()
        {
            navn = "";
            pris = 0;
        }

        public Vare(string navn, double pris) : this() 
        {
            this.Navn = Navn;
            this.Pris = Pris;
        }

        
    }


    class Program
    {

        static void Main(string[] args)
        {


            // Your code here.....


            Vare v = new Vare("Slik",100);
            Console.WriteLine(v.PrisMedMoms().ToString());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
