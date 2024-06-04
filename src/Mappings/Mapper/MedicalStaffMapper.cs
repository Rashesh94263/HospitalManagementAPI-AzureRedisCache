using AutoMapper;
using HospitalManagementSystem.API.src.Models.Domains;
using HospitalManagementSystem.API.src.Models.DTOs;

namespace HospitalManagementSystem.API.src.Mappings.Mapper
{
    public class MedicalStaffMapper
    {

        private readonly IMapper _mapper;

        public MedicalStaffMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public MedicalStaffDTO ConvertToDTO(MedicalStaff medicalStaffModel)
        {
            return _mapper.Map<MedicalStaffDTO>(medicalStaffModel);
        }

        public MedicalStaff ConvertToModel(MedicalStaffDTO medicalStaffDTO)
        {
            return _mapper.Map<MedicalStaff>(medicalStaffDTO);
        }

    }
}
