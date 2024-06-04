using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.API.src.Models.Domains
{
    public class Medicine
    {


        public Guid MedicineId { get; set; }

        public required string MedicineCodeNumber { get; set; }

        public required string MedicineName { get; set; }

        public required string MedicineType { get; set; }

        public required string MedicineDescription { get; set; }

        public required string MedicineStatus { get; set; }

        public required int MedicineQuantity { get; set; }

        public required string MedicineStatusNumber { get; set; }

        public decimal MedicinePrice { get; set; }

        public required string MedicineManufacturer { get; set; }

        public DateTime MedicineExpirationDate { get; set; }

        public DateTime MedicineCreatedDate { get; set; }

        public DateTime? MedicineUpdatedDate { get; set; }

    }
}
