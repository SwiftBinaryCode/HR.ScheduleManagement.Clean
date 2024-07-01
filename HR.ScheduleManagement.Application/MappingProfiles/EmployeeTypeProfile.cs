using AutoMapper;
using HR.ScheduleManagement.Application.Features.EmployeeType.Commands.CreateEmployeeType;
using HR.ScheduleManagement.Application.Features.EmployeeType.Commands.UpdateEmployeeType;
using HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetAllEmployeeTypes;
using HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetEmployeeTypeDetails;
using HR.ScheduleManagement.Domain;

namespace HR.ScheduleManagement.Application.MappingProfiles
{
    public class EmployeeTypeProfile : Profile
    {
        public EmployeeTypeProfile()
        {
            CreateMap<EmployeeTypeDto, EmployeeType>().ReverseMap();
            CreateMap<EmployeeType, EmployeeTypeDetailsDto>();
            CreateMap<CreateEmployeeTypeCommand, EmployeeType>();
            CreateMap<UpdateEmployeeTypeCommand, EmployeeType>();

            
        }
    }
}
