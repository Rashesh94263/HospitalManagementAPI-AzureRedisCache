using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.API.src.Models.DTOs
{
    public class PatientDTO
    {


        [Key]
        public Guid PatientId { get; set; } = Guid.NewGuid();

        [Required, StringLength(50)]
        public string PatientNationId { get; set; }

        [Required, StringLength(100)]
        public string PatientName { get; set; }

        [Required]
        public DateTime PatientDateOfBirth { get; set; }

        [Required, StringLength(10)]
        public string PatientGender { get; set; }


        [Required, StringLength(200)]
        public string PatientAddress { get; set; }

        [Required, StringLength(15)]
        public string PatientNumber { get; set; }


        [Required, EmailAddress, StringLength(100)]
        public string PatientEmail { get; set; }


        [Required, StringLength(15)]
        public string PatientEmergencyContact { get; set; }


        [Required, StringLength(100)]
        public string PatientConditionalIllness { get; set; }



        [Required]
        public Guid PatientResponsibleDoctorId { get; set; }


        [Required, MaxLength(20)]
        public string PatientRoom { get; set; }

        [Required]
        public DateTime PatientAdmissionDate { get; set; }


        public DateTime? PatientDischargeDate { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }


        public DateTime? UpdatedDate { get; set; }




    }
}
