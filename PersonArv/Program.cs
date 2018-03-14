using System;

namespace PersonArv
{

    public class Person
    {

        public string Fornavn { get; set; }
        public string Efternavn { get; set; }


        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }


    }


    public class Elev : Person
    {
        public string Klasselokale { get; set; }

    }

    public class Instruktør
    {
        public int NøgleID { get; set; }

    }

    class Program
    {

        static void Main(string[] args)
        {


            // Your code here.....

            Person p = new Person() { Fornavn = "Lars", Efternavn = "Stefansen" };

            Elev e = new Elev
            {
                Efternavn = "Stefansen",
                Fornavn = "Lars"
            };
            Console.WriteLine(e.FuldtNavn().ToString());

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
