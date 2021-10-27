using DrawIt2.Data;
using DrawIt2.Models;
using DrawIt2.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawIt2.Repositories
{
    public class RoomRepository : IRepository<Room>
    {
        private ApplicationDbContext db;

        public RoomRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Room> GetRoomList()
        {
            return db.Rooms;
        }

        public Room GetRoom(int id)
        {
            return db.Rooms.Find(id);
        }

        public Room Create(Room room)
        {
            db.Rooms.Add(room);
            return room;
        }

        public Room Update(Room room)
        {
            db.Entry(room).State = EntityState.Modified;
            return room;
        }

        public void Delete(int id)
        {
            Room room = db.Rooms.Find(id);
            if (room != null)
                db.Rooms.Remove(room);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
