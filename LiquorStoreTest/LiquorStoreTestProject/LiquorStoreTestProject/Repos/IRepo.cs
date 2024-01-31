using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorStoreTestProject.Repos
{
    public interface IRepo<T>
    {
        void Add(T item);
        T GetById(int id);
        List<T> GetAll();
        void Update(T item);
        void Delete(T item);
    }
}
