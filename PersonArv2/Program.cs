using System;

namespace PersonArv2
{

    class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public virtual string Skriv()
        {
            return Fornavn + " " + Efternavn;
        }


    }

    class Elev : Person
    {

        public string Klasselokale { get; set; }

        public override string Skriv()
        {
            return base.Skriv() + " " + Klasselokale.ToString();
        }

    }


    class Instruktør : Person
    {
        public int NøgleId { get; set; }

        public override string Skriv()
        {
            return base.Skriv() + " " + NøgleId.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....


            Person p = new Person() { Fornavn = "Lars", Efternavn ="Stefansen"};
            Console.WriteLine(p.Skriv());

            Person e = new Elev() { Fornavn = "Lars", Efternavn = "Stefansen" ,Klasselokale = "1A"};
            Console.WriteLine(e.Skriv());

            Person i = new Instruktør() { Fornavn = "Lars", Efternavn = "Stefansen", NøgleId = 10 };
            Console.WriteLine(i.Skriv());

            Person[] a = new Person[3];
            a[0] = p;
            a[1] = e;
            a[2] = i;

            foreach (var item in a)
            {
                Console.WriteLine(item.Skriv());
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
