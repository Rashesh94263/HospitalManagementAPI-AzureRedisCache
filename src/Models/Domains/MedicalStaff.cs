namespace HospitalManagementSystem.API.src.Models.Domains
{
    public class MedicalStaff
    {


        public Guid MedicalStaffId { get; set; }

        public required string MedicalStaffFirstName { get; set; }

        public required string MedicalStaffLastName { get; set; }

        public DateTime MedicalStaffDateOfBirth { get; set; }

        public required string MedicalStaffGender { get; set; }

        public required string MedicalStaffSpeSpecialization { get; set; }

        public required string MedicalStaffShiftingTime { get; set; }

        public DateTime MedicalStaffDateOfEmployment { get; set; }

        public required string MedicalStaffContactNumber { get; set; }

        public required string MedicalStaffEmail { get; set; }

        public required string MedicalStaffAddress { get; set; }

        public required string MedicalStaffRole { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }


    }
}
