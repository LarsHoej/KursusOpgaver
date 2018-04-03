using System;
using System.Collections.Generic;

namespace PersonGeneric
{

    public class Person
    {
        public string Navn { get; set; }

    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }

    public class Kursist : Person
    {
        public int KursistId { get; set; }

    }

    public class Personer
    {
        private List<Person> personer = new List<Person>();

        public void Tilføj(Person p)
        {
            personer.Add(p);
        }
    }

    public class Personer2<T>
    {
        private List<T> personer = new List<T>();

        public void Tilføj(T p)
        {
            personer.Add(p);
        }
    }

    public class Personer3<T> where T : Person
    {
        private List<T> personer = new List<T>();

        public void Tilføj(T p)
        {
            personer.Add(p);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Personer p1 = new Personer();
            p1.Tilføj(new Person() { Navn = "Lars" });

            Personer2<Kursist> p2 = new Personer2<Kursist>();
            p2.Tilføj(new Kursist() { KursistId = 10,Navn = "Lars"});

          
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
