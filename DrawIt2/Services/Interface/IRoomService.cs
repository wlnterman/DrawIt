using DrawIt2.Models;
using DrawIt2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawIt2.Services.Interface
{
    public interface IRoomService
    {
        IEnumerable<RoomViewModel> GetRoomList();
        RoomViewModel GetRoom(int id);
        RoomViewModel Create(RoomViewModel room);
        RoomViewModel Update(RoomViewModel room);
        void Delete(int id);
        void Save();
    }
}
