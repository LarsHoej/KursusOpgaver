using System;

namespace DyrApp
{

    class Dyr
    {
        public string Navn { get; set; }
        static System.Random rnd = new Random();
        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder..." + Navn);
        }
        public static Dyr TilfældigtDyr()
        {

            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);

            if (index % 2 == 0)
                return new Kat() { Navn = navne[index] };
            else
                return new Hund() { Navn = navne[index] };

        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder..." + Navn);
        }
        
    }


    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn );
        }       
    }


    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Dyr[] dyr = new Dyr[50];
            for (int i = 0; i < dyr.Length ; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
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
