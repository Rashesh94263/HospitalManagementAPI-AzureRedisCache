using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.API.src.Models.DTOs
{
    public class MedicineDTO
    {



        [Key]
        public Guid MedicineId { get; set; } = Guid.NewGuid();

        [Required, StringLength(20)]
        public string MedicineCodeNumber { get; set; }

        [Required, StringLength(50)]
        public string MedicineName { get; set; }

        [Required, StringLength(50)]
        public string MedicineType { get; set; }

        [Required, StringLength(500)]
        public string MedicineDescription { get; set; }

        [Required, StringLength(6)]
        public string MedicineStatus { get; set; }

        [Required]

        public int MedicineQuantity { get; set; }

        [Required, MinLength(7), MaxLength(20)]
        public string MedicineStatusNumber { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MedicinePrice { get; set; }

        [Required, StringLength(100)]
        public string MedicineManufacturer { get; set; }


        [Required]
        public DateTime MedicineExpirationDate { get; set; }

        [Required]
        public DateTime MedicineCreatedDate { get; set; }

        public DateTime? MedicineUpdatedDate { get; set; }





    }
}
