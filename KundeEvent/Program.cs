using System;

namespace KundeEvent
{
    
    public class Kunde
    {
        public event EventHandler KreditmaxOverskredet;
        
        
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }

        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                if (KreditmaxOverskredet != null)
                {
                    KreditmaxOverskredet(this, new EventArgs());
                }                
           
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Kunde k = new Kunde();
            k.Navn = "Lars";
            k.Saldo = 0;
            k.KreditMax = -500;
            k.KreditmaxOverskredet += (o, e) => { Console.WriteLine("Kreditmaks er overskrevet...."); };

            k.Køb(100);
            k.Køb(600);

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
