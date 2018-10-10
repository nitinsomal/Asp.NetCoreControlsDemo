using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreControlsDemo.UI.Models
{
    public class LookUpMeetingRoom
    {
        [Key]
        public int MeetingRoomId { get; set; }
        public string MeetingRoomIdentity { get; set; }
        public int? BuildingId { get; set; }
        public int? SeatingCapacity { get; set; }
        public string ResourcesId { get; set; }
        public int? IsActive { get; set; }
        public Guid? ActionBy { get; set; }
        public DateTime? ActionDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
