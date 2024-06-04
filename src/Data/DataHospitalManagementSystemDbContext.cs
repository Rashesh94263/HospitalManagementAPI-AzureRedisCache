using HospitalManagementSystem.API.src.Models.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace HospitalManagementSystem.API.src.Data
{
    public class DataHospitalManagementSystemDbContext : DbContext
    {
        // Logger for database operations
        private readonly ILogger<DataHospitalManagementSystemDbContext> _logger;


        public DataHospitalManagementSystemDbContext(DbContextOptions<DataHospitalManagementSystemDbContext> dbContextOptions,
             ILogger<DataHospitalManagementSystemDbContext> logger) : base(dbContextOptions)
        {

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));


            try
            {
                // Ensures the database is created and initializes its schema
                Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                // Log connection failure
                _logger.LogError(ex, "Failed to establish connection to the database");

                throw; // Re-throw the exception for higher-level handling 

            }

        }

        // DbSet properties for the HospitalManagement System entirties... 
        public DbSet<Clinic> Clinincs { get; set; }

        public DbSet<MedicalStaff> MedicalStaff { get; set; }

        public DbSet<Medicine> Medicine { get; set; }

        public DbSet<Patient> Patient { get; set; }

        public DbSet<Region> Region { get; set; }

    }
}
