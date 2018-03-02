using System;

namespace NyTerning
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Terning
    {
        public int v�rdi;
        private bool snyd;

        private static Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine("[" + this.v�rdi.ToString() +  "]");
        }

        public void Ryst()
        {
            if (snyd == true)
            {
                this.v�rdi = 6;
            }
            else 
            {
                this.v�rdi = rnd.Next(1,7);
            }
        }

        public Terning()
        {
            this.v�rdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd) : this()
        {
            this.snyd = snyd;
        }

    }

}
