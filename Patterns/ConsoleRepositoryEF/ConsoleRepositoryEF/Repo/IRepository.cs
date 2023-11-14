using ConsoleRepositoryEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRepositoryEF.Repo
{
    public interface IRepository
    {
        void Create();
        List<Person> GetAll();
        void Update(Person person);
        void Delete();

        void AddPerson(Person person);

    }

}
