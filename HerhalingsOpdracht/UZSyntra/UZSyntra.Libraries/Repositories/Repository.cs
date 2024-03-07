using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZSyntra.Data.Context;
using UZSyntra.Data.Models;
using UZSyntra.Libraries.Interfaces;

namespace UZSyntra.Libraries.Repositories
{

    //where T: Basemodel zodat we de entity.<property> kunnen gebruiken
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        protected UZSyntraContext _db;
        public Repository(UZSyntraContext db)
        {
            _db = db;
        }

        public virtual void Add(T entity)
        {
            _db.Add(entity);
            entity.CreatedOn = DateTime.Now;
            _db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            T item = GetById(id);
            item.IsDeleted = true;
            _db.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _db.Set<T>().Where(e => e.IsDeleted == false).ToList();
        }

        public virtual T GetById(int id)
        {
            return _db.Find<T>(id);
        }

        public virtual void Update(T entity)
        {
            T old = _db.Set<T>().AsNoTracking().FirstOrDefault(e => e.ID == entity.ID);
            entity.ModifiedOn = DateTime.Now;
            if (old != null)
            {
                entity.CreatedOn = old.CreatedOn;
            }
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}
