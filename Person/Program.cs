using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Person p1 = new Person();
            p1.Fornavn = "Lars";
            p1.Efternavn = "Høj";
            p1.Fødselsår = 1970;
            p1.Adresse = "Jernbanegade 22A";

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());


            Person p2 = new Person("Stefansen", "Lars");
            Console.WriteLine(p2.FuldtNavn());

            p1 = p2;

            Console.WriteLine(p1.FuldtNavn());

            Console.WriteLine(p1.ToString());

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        private string adresse;

        public string Adresse {

            get { return adresse; }
            set { adresse = value; }
        }


        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            return DateTime.Now.Year - Fødselsår;
        }


        public Person()
        {
            Fornavn = "";
            Efternavn = "";
        }

        public Person(string Efternavn, string Fornavn) : this()
        {
            this.Efternavn = Efternavn.ToUpper();
            this.Fornavn = Fornavn.ToUpper();
        }

        public override string ToString()
        {
            return base.ToString() + this.Efternavn + " " + this.Fornavn;
        }
    }
}
