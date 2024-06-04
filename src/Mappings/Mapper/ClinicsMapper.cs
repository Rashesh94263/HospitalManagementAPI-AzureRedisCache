using AutoMapper;
using HospitalManagementSystem.API.src.Models.Domains;
using HospitalManagementSystem.API.src.Models.DTOs;

namespace HospitalManagementSystem.API.src.Mappings.Mapper
{
    public class ClinicsMapper
    {

        private readonly IMapper _mapper;

        public ClinicsMapper(IMapper mapper)
        {
            _mapper = mapper;

        }

        // _mapper convert clinicModel in to the ClinicDTO 
        public ClinicDTO ConvertToDTO(Clinic clinic)
        {
            return _mapper.Map<ClinicDTO>(clinic);
        }

        public Clinic ConvertToModel(ClinicDTO clinicDTO)
        {
            return _mapper.Map<Clinic>(clinicDTO);
        }
    }
}
