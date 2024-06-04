namespace HospitalManagementSystem.API.src.Models.Domains
{
    public class Clinic
    {


        public Guid ClinicId { get; set; } = Guid.NewGuid();


        public string ClinicName { get; set; }


        public string ClinicAddress { get; set; }

        public string ClinicCity { get; set; }

        public string ClinicState { get; set; }

        public string ClinicPostalCode { get; set; }

        public string ClinicCountry { get; set; }

        public string ClinicPhoneNumber { get; set; }

        public string ClinicEmail { get; set; }

        public string ClinicWorkingHours { get; set; }


        public int? ClinicFloorNumber { get; set; }

        public Guid RegionId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastUpdatedDate { get; set; }


    }
}
