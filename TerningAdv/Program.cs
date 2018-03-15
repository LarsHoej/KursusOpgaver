using System;

namespace TerningAdv
{


    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set {
                if (value < 1 || value > 6)
                    værdi = 1;
                else
                    værdi = value;
            }
        }

        private static System.Random rnd;

        public int Ryst()
        {
            return rnd.Next(1, 7);
        }

        static Terning()
        {
            rnd = new Random();
        }

        public Terning()
        {
            Værdi = Ryst();
        }

        public Terning(int værdi)
        {
            Værdi = værdi; 
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + Værdi.ToString() + ']');
        }
    }

    class LudoTerning : Terning
    {


        public bool ErGlobus()
        {
            return Værdi == 3;
        }
        public bool ErStjerne()
        {
            return Værdi == 5;
        }

        public LudoTerning() : base()
        {
        }

        public LudoTerning(int værdi) : base(værdi)
        {
        }

        public override void Skriv()
        {
            
            if (ErGlobus())
                Console.WriteLine("[G]");
            else if (ErStjerne())
                Console.WriteLine("[S]");
            else
                base.Skriv();
            
        }

    }


    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Terning[] l = new Terning[20];
            Terning t;

            for (int i = 0; i < 20; i++)
            {
                l[i] = new LudoTerning();
                l[i].Ryst();

                t = new Terning(l[i].Værdi);

                l[i].Skriv();
                t.Skriv();
                Console.WriteLine("");
            }



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
