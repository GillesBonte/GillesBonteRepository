using ConsoleRepositoryEF.DAL__Data_Access_Layer_;
using ConsoleRepositoryEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRepositoryEF.Repo
{
    public class RepoEF : IRepository
    {
        private PersonContext _pcController;

        public RepoEF()
        {
            _pcController = new PersonContext();
        }

        public void Create()
        {
            for (int i = 0; i < 10; i++)
            {
                Person p1 = new Person()
                {
                    FirstName = "Gilles",
                    LastName = "Bonte",
                    Age = int.Parse("35")
                };
                _pcController.Persons.Add(p1);
                _pcController.SaveChanges();
            }
        }

        public void AddPerson(Person person)
        {
            _pcController.Persons.Add(person);
            _pcController.SaveChanges();
        }

        public void Delete()
        {
            foreach (Person item in _pcController.Persons)
            {
                _pcController.Persons.Remove(item);
            }
            _pcController.SaveChanges();
        }

        public List<Person> GetAll()
        {

            List<Person> allPersons = _pcController.Persons.ToList<Person>();
            return allPersons;

        }

        public void Update(Person person)
        {
            foreach (Person item in _pcController.Persons)
            {

                if (item.Id == person.Id)
                {
                    item.FirstName = person.FirstName;
                    item.LastName = person.LastName;
                    item.Age = person.Age;
                }

            }

        }

    }

}
