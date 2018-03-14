using System;

namespace TrekantConsole
{

    class Trekant
    {
        

        public int Grundlinje { get; private set; }
        
        public int Hoejde { get; private set; }
        
        public Trekant(int grundlinje,int hoejde)
        {
            this.Grundlinje = grundlinje;
            this.Hoejde = hoejde;
        }

        private double areal;

        public double Areal
        {
            get {
                areal = Grundlinje * Hoejde * 0.5;
                return areal;
            }
            private set {}
        }


    }



    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Trekant t = new Trekant(100, 50);

            Console.WriteLine(t.Areal.ToString());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
