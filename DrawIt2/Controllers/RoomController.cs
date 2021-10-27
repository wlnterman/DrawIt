using DrawIt2.Models;
using DrawIt2.Repositories;
using DrawIt2.Repositories.Interface;
using DrawIt2.Services;
using DrawIt2.Services.Interface;
using DrawIt2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrawIt2.Controllers
{
    public class RoomController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        IRoomService roomService;

        public RoomController(IRoomService roomservice)
        {
            this.roomService = roomservice;
        }




        [HttpPost]
        public IActionResult CreateRoom(string roomName, string userCount)
        {
            string authData = $"RoomName: {roomName}   Users: {userCount}";
            return Content(authData);
        }


        public ActionResult Index()
        {
            return View(roomService.GetRoomList());
        }


        [HttpPost]
        public ActionResult Create(RoomViewModel roomViewModel)
        {
            if (ModelState.IsValid)
            {
                var createdRoom = roomService.Create(roomViewModel);
                return RedirectToAction("Room", new { id = createdRoom.RoomId });
            }
            return RedirectToAction("Index");//View(roomViewModel);
        }


        [HttpPost]
        public ActionResult Edit(RoomViewModel roomViewModel)
        {
            if (ModelState.IsValid)
            {
                roomService.Update(roomViewModel);
                return RedirectToAction("Index");
            }
            return View(roomViewModel);
        }

        public ActionResult DeleteConfirmed(int id)
        {
            roomService.Delete(id);
            return RedirectToAction("Index");
        }


        public ActionResult Room(int id)
        {
            return View(roomService.GetRoom(id));
        }

        public ActionResult Create()
        {
            return View();
        }
        
        public ActionResult Edit(int id)
        {
            return View(roomService.GetRoom(id));
        }

       

        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    Room room = db.GetRoom(id);
        //    return View(room);
        //}
        //[HttpPost, ActionName("Delete")]
        

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}


    }
}
