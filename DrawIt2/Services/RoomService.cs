using DrawIt2.Models;
using DrawIt2.Repositories;
using DrawIt2.Repositories.Interface;
using DrawIt2.Services.Interface;
using DrawIt2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawIt2.Services
{
    public class RoomService : IRoomService
    {
        IRepository<Room> roomRepository;

        public RoomService(IRepository<Room> repository)
        {
            this.roomRepository = repository;
        }


        public IEnumerable<RoomViewModel> GetRoomList()
        {
            var rooms = roomRepository.GetRoomList();
            var roomList = rooms.Select(room => new RoomViewModel(room));
            return roomList;
            //throw new NotImplementedException();
        }


        public RoomViewModel GetRoom(int id)
        {
            return new RoomViewModel(roomRepository.GetRoom(id));
            //throw new NotImplementedException();
        }


        public RoomViewModel Create(RoomViewModel item)
        {
            var room = new Room(item.RoomName,item.UserCount);
            var createdRoom = roomRepository.Create(room);
            roomRepository.Save();
            return new RoomViewModel(createdRoom);
            // new NotImplementedException();
        }


        //public RoomViewModel CreateRoom(String roomName, int userCount)
        //{
        //    var room = new Room(roomName, userCount);

        //    return new RoomViewModel();
        //}


        public RoomViewModel Update(RoomViewModel item)
        {
            var room = new Room(item.RoomName, item.UserCount);
            var updatedRoom = roomRepository.Update(room);
            roomRepository.Save();
            return new RoomViewModel(updatedRoom);
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            roomRepository.Delete(id);
            //throw new NotImplementedException();
        }


        public void Save()
        {
            roomRepository.Save();
            //throw new NotImplementedException();
        }
    }
}
