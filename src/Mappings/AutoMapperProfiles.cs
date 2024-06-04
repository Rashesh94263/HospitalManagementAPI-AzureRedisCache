using AutoMapper;
using HospitalManagementSystem.API.src.Models.Domains;
using HospitalManagementSystem.API.src.Models.DTOs;

namespace HospitalManagementSystem.API.src.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Clinic, ClinicDTO>().ReverseMap();
            CreateMap<MedicalStaff, MedicalStaffDTO>().ReverseMap();
            CreateMap<Medicine, MedicineDTO>().ReverseMap();
            CreateMap<Patient, PatientDTO>().ReverseMap();
            CreateMap<Region, RegionsDTO>().ReverseMap();

        }

    }

}
