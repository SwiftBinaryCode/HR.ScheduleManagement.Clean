using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Queries.GetAllTasksTypes
{

    public record GetTaskTypesQuery : IRequest<List<TaskTypeDto>>;
}
