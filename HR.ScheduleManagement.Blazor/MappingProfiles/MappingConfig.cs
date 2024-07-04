using AutoMapper;
using HR.ScheduleManagement.Blazor.Models.EmployeeTypes;
using HR.ScheduleManagement.Blazor.Models.TaskTypes;
using HR.ScheduleManagement.Blazor.Services.Base;

namespace HR.ScheduleManagement.Blazor.MappingProfiles
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<EmployeeTypeDto, EmployeeTypeVM>().ReverseMap();
            CreateMap<EmployeeTypeDetailsDto, EmployeeTypeVM>().ReverseMap();
            CreateMap<CreateEmployeeTypeCommand, EmployeeTypeVM>().ReverseMap();
            CreateMap<UpdateEmployeeTypeCommand, EmployeeTypeVM>().ReverseMap();

            CreateMap<TaskTypeDto, TaskTypeVM>().ReverseMap();
            CreateMap<TaskTypeDetailsDto, TaskTypeVM>().ReverseMap();
            CreateMap<CreateTaskTypeCommand, TaskTypeVM>().ReverseMap();
            CreateMap<UpdateTaskTypeCommand, TaskTypeVM>().ReverseMap();
        }
    }
}
