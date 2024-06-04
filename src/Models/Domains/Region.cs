using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.API.src.Models.Domains
{
    public class Region
    {




        public int RegionId { get; set; }
        public required string RegionName { get; set; }
        public char RegionType { get; set; }

        public required string RegionDescription { get; set; }

        public DateTime RegionCreateTime { get; set; }


        public DateTime? RegionUpdateTime { get; set; }

    }
}
