using Microsoft.EntityFrameworkCore.Update.Internal;

namespace MVCRecapture.Interfaces
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public void Add(T entity);
    }
}
