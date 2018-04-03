using System;
using System.Collections.Generic;

namespace KortStack
{
    public class Kort
    {
        public int V�rdi { get; set; }
        public string Kul�r { get; set; }

        public override string ToString()
        {
            return this.Kul�r + " " + this.V�rdi;
        }

    }


    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void Tilf�jKort(Kort k)
        {
            bunke.Push(k);
        }

        public Kort FjernKort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();
            else
                return new Kort();
            
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }

        }


    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Bunke b = new Bunke();
            b.Tilf�jKort(new Kort() { Kul�r = "Spar", V�rdi = 2 });
            b.Tilf�jKort(new Kort() { Kul�r = "Hjerter", V�rdi = 14 });
            b.Tilf�jKort(new Kort() { Kul�r = "Ruder", V�rdi = 3 });
            Console.WriteLine("");
            b.Vis();
            Console.WriteLine("");

            Kort k = new Kort();
            k = b.FjernKort();
            Console.WriteLine(k);

            k = b.FjernKort();
            Console.WriteLine(k);

            Console.WriteLine("");
            b.Vis();

            k = b.FjernKort();
            k = b.FjernKort();
            k = b.FjernKort();
            k = b.FjernKort();



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
