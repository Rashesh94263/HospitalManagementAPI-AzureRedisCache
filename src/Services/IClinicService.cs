using HospitalManagementSystem.API.src.Models.DTOs;

namespace HospitalManagementSystem.API.src.Services
{
    public interface IClinicService
    {

        Task<IEnumerable<ClinicDTO>> GetAllClinicsAync(int page, int pageSize);

        Task<ClinicDTO> GetClinicByIdAsync(Guid id);
    }
}
