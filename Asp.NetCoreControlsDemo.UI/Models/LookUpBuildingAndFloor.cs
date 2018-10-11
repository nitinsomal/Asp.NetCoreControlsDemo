using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreControlsDemo.UI.Models
{
    public class LookUpBuildingAndFloor
    {
        [Key]
        public int BuildingFloorId { get; set; }
        public string BuildingFloorName { get; set; }
        public int? IsActive { get; set; }
        public Guid? ActionBy { get; set; }
        public DateTime? ActionDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }
}
