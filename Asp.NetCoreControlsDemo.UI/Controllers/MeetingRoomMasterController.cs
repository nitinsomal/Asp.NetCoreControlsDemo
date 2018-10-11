using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreControlsDemo.UI.Models;
using Asp.NetCoreControlsDemo.UI.Repositry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp.NetCoreControlsDemo.UI.Controllers
{
    public class MeetingRoomMasterController : Controller
    {
        private DevDBContext devDBContext;

        public MeetingRoomMasterController(DevDBContext ctx)
        {
            devDBContext = ctx;
        }


        public IActionResult Index()
        {
            List<LookUpBuildingAndFloor> lstBuildingAndFloor = new List<LookUpBuildingAndFloor>();

            lstBuildingAndFloor = devDBContext.LookUpBuildingAndFloor.ToList();
            lstBuildingAndFloor.Insert(0, new LookUpBuildingAndFloor { BuildingFloorId = 0, BuildingFloorName = "Select Building" });
            ViewBag.LookUpBuildingAndFloor = lstBuildingAndFloor;

            return View();
        }

        public JsonResult MeetingRoomDetail(int id)
        {
            
            List<LookUpMeetingRoom> lstMeetingRoom = new List<LookUpMeetingRoom>();

            int? BuilId = id;
            lstMeetingRoom = devDBContext.LookUpMeetingRoom.Where(l => l.BuildingId == BuilId).ToList();

            //.Select(l => l.BuildingId == BuildingId).ToList<LookUpMeetingRoom>();

            //lstBuildingAndFloor = DBContext_Dev.LookUpBuildingAndFloor.ToList();
            //lstBuildingAndFloor.Insert(0, new LookUpBuildingAndFloor { BuildingFloorId = 0, BuildingFloorName = "Select Building" });
            //ViewBag.LookUpBuildingAndFloor = lstBuildingAndFloor;

            return Json(new SelectList(lstMeetingRoom, "MeetingRoomId", "MeetingRoomIdentity"));
        }

    }
}