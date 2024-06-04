using AutoMapper;
using HospitalManagementSystem.API.src.Models.Domains;
using HospitalManagementSystem.API.src.Models.DTOs;

namespace HospitalManagementSystem.API.src.Mappings.Mapper
{
    public class RegionMapper
    {

        private readonly IMapper _mapper;

        public RegionMapper(IMapper mapper)

        {
            _mapper = mapper;
        }

        public RegionsDTO ConvertToDTO(Region regionModel)
        {
            return _mapper.Map<RegionsDTO>(regionModel);
        }

        public Region ConvertToModel(Region regionModel)
        {
            return _mapper.Map<Region>(regionModel);
        }
    }
}
