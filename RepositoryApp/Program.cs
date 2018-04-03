using System;

namespace RepositoryApp
{

    public class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

    }

    public interface IPersonRespository
    {
        Person[] GetAll();
        Person Get(int id);
    }

    public class PersonRepositoryMock : IPersonRespository
    {
        public Person Get(int id)
        {
            return new Person() { Id = 1, Name = "#1", DateOfBirth = new DateTime(2000, 1, 1) };
        }

        public Person[] GetAll()
        {
            Person[] lst = new Person[2];
            lst[0] = new Person() { Id = 1, Name = "#1", DateOfBirth = new DateTime(2000, 1, 1) };
            lst[1] = new Person() { Id = 2, Name = "#2", DateOfBirth = new DateTime(2010, 1, 1) };
            return lst;
        }
    }

    public class PersonRepositoryJson : IPersonRespository
    {
        private string filename;

        public Person Get(int id)
        {
            var lst = GetAll();
            foreach (var item in lst)
            {
                if (item.Id == id)
                    return item;
            }
            throw new ApplicationException("Person not found");
        }

        public Person[] GetAll()
        {
            string json = System.IO.File.ReadAllText(filename);
            var lst = Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(Person[])) as Person[];
            return lst;
        }

        public PersonRepositoryJson(string filename)
        {
            this.filename = filename;
        }
    }

    public static class PersonRepositoryGenerator
    {
        public static IPersonRespository GetPersonRepository()
        {
            string repository = System.Configuration.ConfigurationManager .AppSettings["PersonRepository"];
            
            switch (repository)
            {
                case "PersonRepositoryJson":
                    string filename = System.Configuration.ConfigurationManager.AppSettings["JSonFilename"];
                    return new PersonRepositoryJson(filename); 
                case "PersonRepositoryMock":
                    return new PersonRepositoryMock();
                default:
                    throw new ApplicationException("Respository not found in config");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            PersonRepositoryMock rep1 = new PersonRepositoryMock();
            foreach (var item in rep1.GetAll())
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.DateOfBirth}");
            }
            Person p1 = rep1.Get(1);
            Console.WriteLine($"{p1.Id} {p1.Name} {p1.DateOfBirth}");

            PersonRepositoryJson rep2 = new PersonRepositoryJson(@"x:\marx.json");
            foreach (var item in rep2.GetAll())
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.DateOfBirth}");
            }
            Person p2 = rep2.Get(1);
            Console.WriteLine($"{p2.Id} {p2.Name} {p2.DateOfBirth}");


            IPersonRespository rep3;
            rep3 = new PersonRepositoryMock();
            //rep3 = new PersonRepositoryJson(@"x:\marx.json");
            foreach (var item in rep3.GetAll())
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.DateOfBirth}");
            }
            Person p3 = rep3.Get(1);
            Console.WriteLine($"{p3.Id} {p3.Name} {p3.DateOfBirth}");

            IPersonRespository rep4 = PersonRepositoryGenerator.GetPersonRepository();
            foreach (var item in rep4.GetAll())
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.DateOfBirth}");
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
