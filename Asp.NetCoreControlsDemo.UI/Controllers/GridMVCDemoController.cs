using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreControlsDemo.UI.Models;
using Asp.NetCoreControlsDemo.UI.Repositry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetCoreControlsDemo.UI.Controllers
{
    public class GridMVCDemoController : Controller
    {
        private DevDBContext devDBContext;
        public GridMVCDemoController(DevDBContext ctx)
        {
            devDBContext = ctx;
        }

        public IActionResult Index()
        {
            //List<LookUpMeetingRoom> lstLookUpMeetingRoom = new List<LookUpMeetingRoom>();
            //lstLookUpMeetingRoom = devDBContext.LookUpMeetingRoom.ToList();
            //ViewBag.LookUpMeetingRoom = lstLookUpMeetingRoom;
               
            
            // Using Linq query
            var result = (from c in devDBContext.LookUpMeetingRoom
                          select new LookUpMeetingRoom
                          {
                              MeetingRoomId = c.MeetingRoomId,
                              MeetingRoomIdentity = c.MeetingRoomIdentity,
                              BuildingId = c.BuildingId,
                              SeatingCapacity = c.SeatingCapacity,
                              ResourcesId = c.ResourcesId,
                              IsActive = c.IsActive,
                              ActionBy = c.ActionBy,
                              ActionDate = c.ActionDate,
                              UpdatedBy = c.UpdatedBy,
                              UpdatedDate = c.UpdatedDate
                          }).ToList();

            return View(result);
        }
    }
}