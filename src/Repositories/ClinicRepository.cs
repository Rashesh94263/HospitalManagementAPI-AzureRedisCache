using HospitalManagementSystem.API.src.Data;
using HospitalManagementSystem.API.src.Exceptions;
using HospitalManagementSystem.API.src.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.API.src.Repositories
{
    public class ClinicRepository : IClinicRepository
    {
        // DbContext for database operations
        private readonly DataHospitalManagementSystemDbContext _hospitalManagementSystemDbContext;

        public ClinicRepository(
            DataHospitalManagementSystemDbContext dataHospitalManagementSystemDbContext)
        {
            _hospitalManagementSystemDbContext = dataHospitalManagementSystemDbContext;
        }

        public async Task<IEnumerable<Clinic>> GetAllClinicAsync(int page, int pageSize)
        {
            try
            {
                // Retrieve clinics from the database
                return await _hospitalManagementSystemDbContext.Clinincs
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ClinicInitializationException("Invalid Record :: " + ex.Message);
            }

        }

        public async Task<Clinic> GetClinicByIdAsync(Guid id)
        {
            try
            {
                // Fetch clinic details by Id 
                return await _hospitalManagementSystemDbContext.Clinincs.FirstOrDefaultAsync(Clinic => Clinic.ClinicId == id);

            }
            catch (Exception ex)
            {
                throw new ClinicInitializationException("Invalid ClinicId :: " + ex.Message);
            }
        }

    }
}
