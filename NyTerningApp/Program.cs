using System;

namespace NyTerningApp
{

    class Terning
    {

       private int v�rdi;

       private static System.Random rnd; 
        
        public int V�rdi
        {
            get { return v�rdi; }
            set
            {
                if (value < 1 || value > 6)
                    v�rdi = 1;
                else
                    v�rdi = value;
            }
        }


        public int Ryst()
        {
            return rnd.Next(1, 7);
        }


        public string Skriv()
        {
            return v�rdi.ToString();
        }

        public Terning()
        {
            rnd = new Random();
            V�rdi = this.Ryst();
        }

        public Terning(int v�rdi) : this()
        {
            V�rdi = v�rdi;
        }

    }


    class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {

        }

        public LudoTerning(int v�rdi) : base(v�rdi)
        {

        }

        public bool ErGlobus()
        {
            
            return this.V�rdi==3;
        }

        public bool ErStjerne()
        {
            return this.V�rdi==5;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Terning t = new Terning();
            Console.WriteLine(t.Skriv());

            LudoTerning l = new LudoTerning(t.V�rdi);
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
