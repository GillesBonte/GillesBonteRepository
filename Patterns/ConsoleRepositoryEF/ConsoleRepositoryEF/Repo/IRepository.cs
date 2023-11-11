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
        public void Create();
        public List<Person> GetAll();
        public void Update();
        public void Delete();

    }

}
