using AutoMapper;
using HospitalManagementSystem.API.src.Models.Domains;
using HospitalManagementSystem.API.src.Models.DTOs;


namespace HospitalManagementSystem.API.src.Mappings.Mapper
{
    public class MedicineMapper
    {
        private readonly IMapper _mapper;

        public MedicineMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public MedicineDTO ConvertToDTO(Medicine medicineModel)
        {
            return _mapper.Map<MedicineDTO>(medicineModel);
        }

        public Medicine ConvertToModel(MedicineDTO medicineDTO)
        {
            return _mapper.Map<Medicine>(medicineDTO);
        }



    }
}
