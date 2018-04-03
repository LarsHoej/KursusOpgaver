using System;
using System.Collections.Generic;

namespace PersonCollection
{

    public class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            List<Person> list = new List<Person>();
            list.Add(new Person() { Id = 1, Navn = "Lars" });
            list.Add(new Person() { Id = 2, Navn = "Maria" });
            list.Add(new Person() { Id = 3, Navn = "Mads" });

            foreach (var item in list)
            {
                Console.WriteLine(item.Navn);
            }


            Dictionary<int,Person> dir = new Dictionary<int,Person>();
            dir.Add(10000, new Person() { Id = 1, Navn = "Lars" });
            dir.Add(20000, new Person() { Id = 2, Navn = "Maria" });
            dir.Add(30000, new Person() { Id = 3, Navn = "Mada" });

            Person p1 = new Person();

            p1 = dir[20000];            
            Console.WriteLine(p1.Navn);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
