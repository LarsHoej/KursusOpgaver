using System;

namespace KundeEvent
{
    
    public class Kunde
    {
        public event EventHandler KreditmaxOverskredet;
        
        
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }

        public void K�b(int v�rdi)
        {
            Console.WriteLine("Kunde {0} k�ber for {1}", Navn, v�rdi);
            this.Saldo -= v�rdi;
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

            k.K�b(100);
            k.K�b(600);

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
