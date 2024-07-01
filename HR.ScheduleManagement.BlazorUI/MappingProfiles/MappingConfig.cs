using AutoMapper;
using HR.ScheduleManagement.BlazorUI.Models.EmployeeTypes;
using HR.ScheduleManagement.BlazorUI.Services.Base;

namespace HR.ScheduleManagement.BlazorUI.MappingProfiles
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<EmployeeTypeDto, EmployeeTypeVM>().ReverseMap();
            CreateMap<CreateEmployeeTypeCommand, EmployeeTypeVM>().ReverseMap();
            CreateMap<UpdateEmployeeTypeCommand, EmployeeTypeVM>().ReverseMap();

        }
    }
}
