using AutoMapper;
using HR.ScheduleManagement.Application.Features.TaskType.Commands.CreateTaskType;
using HR.ScheduleManagement.Application.Features.TaskType.Commands.UpdateTaskType;
using HR.ScheduleManagement.Application.Features.TaskType.Queries.GetAllTasksTypes;
using HR.ScheduleManagement.Application.Features.TaskType.Queries.GetTaskTypeDetails;
using HR.ScheduleManagement.Domain;

namespace HR.ScheduleManagement.Application.MappingProfiles
{
    public class TaskTypeProfile : Profile
    {
        public TaskTypeProfile()
        {
            CreateMap<TaskTypeDto, TaskType>().ReverseMap();
            CreateMap<TaskType, TaskTypeDetailsDto>();
            CreateMap<CreateTaskTypeCommand, TaskType>();
            CreateMap<UpdateTaskTypeCommand, TaskType>();


        }
    }
}
