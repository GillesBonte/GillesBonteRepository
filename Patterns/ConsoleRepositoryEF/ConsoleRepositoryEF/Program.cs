using ConsoleRepositoryEF.DAL__Data_Access_Layer_;
using ConsoleRepositoryEF.Models;
using ConsoleRepositoryEF.Repo;
using System.Data.Entity.Migrations.Model;

namespace ConsoleRepositoryEF
{
    internal class Program
    {
        static private PersonContext pcController = new PersonContext();
        static private List<Person> allPersons = new List<Person>();
        static private IEnumerable<string> _lindseys = new List<string>();

        static void Main(string[] args)
        {

            RepoEF repo = new RepoEF();
            repo.Create();
            Person mystery = new Person() {FirstName = "Lemmy", LastName = "Weirdo", Age = 0 };
            repo.AddPerson(mystery);
            Console.ReadLine();
            mystery.Age = 100;
            repo.Update(mystery);
            ShowListOfPersons(repo.GetAll());
            Console.Clear();
            Console.ReadLine();

            IEnumerable<Person> lemmys = new List<Person>();

            lemmys = from person in repo.GetAll()
                     where person.FirstName == "Lemmy"
                     select person;

            ShowListOfPersons(lemmys);



        }



        static void ShowListOfPersons(IEnumerable<Person> persons)
        {
            foreach (Person item in persons)
            {
                Console.WriteLine($"{item.Id} {item.LastName} {item.FirstName} {item.Age}");
            }

        }
    }
}