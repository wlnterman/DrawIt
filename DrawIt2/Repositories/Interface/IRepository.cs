using DrawIt2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawIt2.Repositories.Interface
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetRoomList();
        T GetRoom(int id);
        Room Create(T item);
        Room Update(T item);
        void Delete(int id);
        void Save();
    }
}
