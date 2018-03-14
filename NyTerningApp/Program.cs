using System;

namespace NyTerningApp
{

    class Terning
    {

       private int værdi;

       private static System.Random rnd; 
        
        public int Værdi
        {
            get { return værdi; }
            set
            {
                if (value < 1 || value > 6)
                    værdi = 1;
                else
                    værdi = value;
            }
        }


        public int Ryst()
        {
            return rnd.Next(1, 7);
        }


        public string Skriv()
        {
            return værdi.ToString();
        }

        public Terning()
        {
            rnd = new Random();
            Værdi = this.Ryst();
        }

        public Terning(int værdi) : this()
        {
            Værdi = værdi;
        }

    }


    class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {

        }

        public LudoTerning(int værdi) : base(værdi)
        {

        }

        public bool ErGlobus()
        {
            
            return this.Værdi==3;
        }

        public bool ErStjerne()
        {
            return this.Værdi==5;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Terning t = new Terning();
            Console.WriteLine(t.Skriv());

            LudoTerning l = new LudoTerning(t.Værdi);
            Console.WriteLine(l.ErGlobus().ToString());
            Console.WriteLine(l.ErStjerne().ToString());

            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
