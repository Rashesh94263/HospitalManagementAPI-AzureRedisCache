using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.API.src.Models.Domains
{
    public class Patient
    {

        public Guid PatientId { get; set; }

        public required string PatientNationId { get; set; }

        public required string PatientName { get; set; }

        public DateTime PatientDateOfBirth { get; set; }

        public required string PatientGender { get; set; }

        public required string PatientAddress { get; set; }

        public required string PatientNumber { get; set; }

        public required string PatientEmail { get; set; }

        public required string PatientEmergencyContact { get; set; }

        public required string PatientConditionalIllness { get; set; }

        public Guid PatientResponsibleDoctorId { get; set; }

        public required string PatientRoom { get; set; }

        public DateTime PatientAdmissionDate { get; set; }

        public DateTime? PatientDischargeDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }


    }
}
