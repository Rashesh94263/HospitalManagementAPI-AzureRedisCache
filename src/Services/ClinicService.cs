using AutoMapper;
using HospitalManagementSystem.API.src.Exceptions;
using HospitalManagementSystem.API.src.Mappings.Mapper;
using HospitalManagementSystem.API.src.Models.DTOs;
using HospitalManagementSystem.API.src.Repositories;

namespace HospitalManagementSystem.API.src.Services
{
    public class ClinicService : IClinicService
    {

        // Repository for clinic data access
        private readonly IClinicRepository _clinicRepository;

        // Mapper for converting between clinic entities and DTOs
        private readonly ClinicsMapper _clinicsMapper;

        // Service for Redis cache interactions
        private readonly RedisCacheServices _redisCacheServices;


        public ClinicService(IClinicRepository clinicRepository, IMapper mapper, RedisCacheServices redisCacheServices)
        {
            _clinicRepository = clinicRepository;
            _clinicsMapper = new ClinicsMapper(mapper);
            _redisCacheServices = redisCacheServices; ;
        }

        public async Task<IEnumerable<ClinicDTO>> GetAllClinicsAync(int page, int pageSize)

        {
            try
            {
                string cacheKey = $"clinicData:page={page}:pageSize={pageSize}";

                // Fetch from cache a database
                var clinicData = await _redisCacheServices.GetFromCacheAsync(
                    cacheKey,
                    async () => await _clinicRepository.GetAllClinicAsync(page, pageSize)
                    );

                // Convert to DTO
                return clinicData.Select(clinic => _clinicsMapper.ConvertToDTO(clinic));
            }
            catch (Exception ex)
            {
                throw new ClinicInitializationException("Error with the Azure Cache: " + ex.Message);
            }

        }

        public async Task<ClinicDTO> GetClinicByIdAsync(Guid clinicId)
        {
            try
            {
                string cacheKey = $"clinic:{clinicId}";

                // Fetch from cache a database and find by clinicId

                var clinicsData = await _redisCacheServices.GetFromCacheAsync
                    (
                        cacheKey,
                        async () => await _clinicRepository.GetClinicByIdAsync(clinicId)
                    );

                if (clinicsData == null)
                {
                    throw new KeyNotFoundException($"Clinic with ID {clinicId} not found.");

                }

                return _clinicsMapper.ConvertToDTO(clinicsData);


            }
            catch (Exception err)
            {
                throw new ClinicInitializationException("Error with the Azure Cache: " + err.Message);
            }



        }

    }
}
