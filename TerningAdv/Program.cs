using System;

namespace TerningAdv
{


    class Terning
    {
        private int v�rdi;

        public int V�rdi
        {
            get { return v�rdi; }
            set {
                if (value < 1 || value > 6)
                    v�rdi = 1;
                else
                    v�rdi = value;
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
            V�rdi = Ryst();
        }

        public Terning(int v�rdi)
        {
            V�rdi = v�rdi; 
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + V�rdi.ToString() + ']');
        }
    }

    class LudoTerning : Terning
    {


        public bool ErGlobus()
        {
            return V�rdi == 3;
        }
        public bool ErStjerne()
        {
            return V�rdi == 5;
        }

        public LudoTerning() : base()
        {
        }

        public LudoTerning(int v�rdi) : base(v�rdi)
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

                t = new Terning(l[i].V�rdi);

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
