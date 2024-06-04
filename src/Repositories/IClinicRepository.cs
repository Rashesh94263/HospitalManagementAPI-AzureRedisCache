using HospitalManagementSystem.API.src.Models.Domains;

namespace HospitalManagementSystem.API.src.Repositories
{
    public interface IClinicRepository
    {

        Task<IEnumerable<Clinic>> GetAllClinicAsync(int page, int pageSize);
        Task<Clinic> GetClinicByIdAsync(Guid id);
    }
}
