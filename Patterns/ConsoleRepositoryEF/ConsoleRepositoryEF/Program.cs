using ConsoleRepositoryEF.DAL__Data_Access_Layer_;
using ConsoleRepositoryEF.Models;
using System.Data.Entity.Migrations.Model;

namespace ConsoleRepositoryEF
{
    internal class Program
    {
        static private PersonContext pcController = new PersonContext();
        static private List<Person> allPersons = new List<Person>();

        static void Main(string[] args)
        {
            GetAll();

            foreach (Person person in allPersons)
            {
                if (person.FirstName == "Lindsey")
                {
                    Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName} {person.Age}");
                }
            }

        }

        static void AddData()
        {
            for (int i = 0; i < 10; i++)
            {
                Person p1 = new Person()
                {
                    FirstName = "Gilles",
                    LastName = "Bonte",
                    Age = int.Parse("35")
                };
                pcController.Persons.Add(p1);
                pcController.SaveChanges();
            }
        }
        static void GetAll()
        {
            allPersons = pcController.Persons.ToList<Person>();
        }
        static void ShowAll()
        {
            foreach (Person item in allPersons)
            {
                Console.WriteLine($"{item.Id} {item.LastName} {item.FirstName} {item.LastName}");
            }

        }
    }
}