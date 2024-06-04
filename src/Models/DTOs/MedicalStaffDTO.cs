using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.API.src.Models.DTOs
{
    public class MedicalStaffDTO
    {

        [Key]
        public Guid MedicalStaffId { get; set; } = Guid.NewGuid();

        [Required, StringLength(50)]
        public string MedicalStaffFirstName { get; set; }

        [Required, StringLength(50)]
        public string MedicalStaffLastName { get; set; }

        [Required]
        public DateTime MedicalStaffDateOfBirth { get; set; }

        [Required, StringLength(10)]
        public string MedicalStaffGender { get; set; }

        [Required, StringLength(100)]
        public string MedicalStaffSpeSpecialization { get; set; }

        [Required, StringLength(50)]
        public string MedicalStaffShiftingTime { get; set; }

        [Required]
        public DateTime MedicalStaffDateOfEmployment { get; set; }

        [Required, StringLength(15)]
        public string MedicalStaffContactNumber { get; set; }

        [EmailAddress, StringLength(50)]
        public string MedicalStaffEmail { get; set; }

        [Required, StringLength(100)]
        public string MedicalStaffAddress { get; set; }

        [Required, StringLength(50)]
        public string MedicalStaffRole { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }



    }
}
