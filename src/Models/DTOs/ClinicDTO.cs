using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HospitalManagementSystem.API.src.Models.DTOs
{
    public class ClinicDTO
    {

        [Key]
        public Guid ClinicId { get; set; } = Guid.NewGuid();

        [Required, StringLength(100)]
        public string ClinicName { get; set; }

        [Required, StringLength(100)]
        public string ClinicAddress { get; set; }

        [Required, StringLength(100)]
        public string ClinicCity { get; set; }

        [Required, StringLength(12)]
        public string ClinicState { get; set; }

        [Required, StringLength(20)]
        public string ClinicPostalCode { get; set; }

        [Required, StringLength(20)]
        public string ClinicCountry { get; set; }

        [Required, StringLength(20)]
        public string ClinicPhoneNumber { get; set; }

        [Required, StringLength(50)]
        public string ClinicEmail { get; set; }

        [Required, StringLength(50)]
        public string ClinicWorkingHours { get; set; }

        public int? ClinicFloorNumber { get; set; }

        [Required]
        public Guid RegionId { get; set; } // Assuming RegionId is also a Guid

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? LastUpdatedDate { get; set; }


    }
}
