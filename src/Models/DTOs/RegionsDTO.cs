using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.API.src.Models.DTOs
{
    public class RegionsDTO
    {




        [Key]
        public Guid RegionId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string RegionName { get; set; }

        [Required]
        [StringLength(100)]
        public string RegionDescription { get; set; }

        [Required]
        public DateTime RegionCreateTime { get; set; }


        public DateTime? RegionUpdateTime { get; set; }


    }
}

