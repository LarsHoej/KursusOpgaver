using System;

namespace PersonConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Person p = new Person();
            p.Efternavn = "Stefansen";
            p.Fornavn = "Lars";

            Console.WriteLine(p.FuldtNavn());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.ToString().Length <= 3)
                    efternavn = "";
                else
                    efternavn = value;
            }
        }

        public string FuldtNavn()
        {
            return this.Efternavn + " " + this.Fornavn;
        }


    }

}
