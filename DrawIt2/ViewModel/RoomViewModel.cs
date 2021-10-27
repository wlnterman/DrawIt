using DrawIt2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawIt2.ViewModel
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }
        public String RoomName { get; set; }
        public int UserCount { get; set; }

        public RoomViewModel() { }
        public RoomViewModel(Models.Room room)
        {
            this.RoomId = room.RoomId;
            this.RoomName = room.RoomName;
            this.UserCount = room.UserCount;
        }
    }
}
