using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawIt2.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public String RoomName { get; set; }
        public int UserCount { get; set; }
        public Room(String roomName, int userCount)
        {
            this.RoomName = roomName;
            this.UserCount = userCount;
        }
        
    }
}
