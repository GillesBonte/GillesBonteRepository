using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZSyntra.Data.Context;
using UZSyntra.Data.Models;

namespace UZSyntra.Libraries.Repositories
{
    public class RoomRepository : Repository<Room>
    {
        public RoomRepository(UZSyntraContext db) : base(db)
        {
        }

        //public override void Add(Room entity)
        //{
        //    base.Add(entity);
        //}

        public override IEnumerable<Room> GetAll()
        {
            return _db.Rooms.Include(r => r.Beds).Where(e => !e.IsDeleted).ToList();
        }

        public override Room GetById(int id)
        {
            return _db.Rooms
                .Include(r => r.Beds)
                .Where(e => !e.IsDeleted && e.ID == id).FirstOrDefault();

        }

    }

}
