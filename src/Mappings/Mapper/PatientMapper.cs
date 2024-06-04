using AutoMapper;
using HospitalManagementSystem.API.src.Models.Domains;
using HospitalManagementSystem.API.src.Models.DTOs;

namespace HospitalManagementSystem.API.src.Mappings.Mapper
{
    public class PatientMapper
    {



        private readonly IMapper _mapper;

        public PatientMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PatientDTO ConvertToDTO(Patient patientModel)
        {
            return _mapper.Map<PatientDTO>(patientModel);
        }

        public Patient ConvertToModel(PatientDTO patientDTO)
        {
            return _mapper.Map<Patient>(patientDTO);
        }
    }
}
