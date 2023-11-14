using ConsoleRepositoryEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ConsoleRepositoryEF.Repo
{

    public class RepoJSON : IRepository
    {
        string _jsonFile;

        public RepoJSON()
        {
            _jsonFile = Environment.CurrentDirectory + "/Data/persons.json";
        }

        public void Create()
        {

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            List<Person> persons;

            try
            {
                using StreamReader reader = new(_jsonFile);
                string json = reader.ReadToEnd();
                persons = JsonSerializer.Deserialize<List<Person>>(json);

            }
            catch (Exception)
            {
                persons = new List<Person>();
            }

            return persons;
        }

        public void AddPerson(Person person)
        {
            List<Person> persons = (this as IRepository).GetAll();
            persons.Add(person);
            string jsonString = JsonSerializer.Serialize<List<Person>>(persons);
            File.WriteAllText(_jsonFile,jsonString);
        }

        public void Update(Person person)
        {
        }
    }

}
