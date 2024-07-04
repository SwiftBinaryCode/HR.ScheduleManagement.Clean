using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Queries.GetTaskTypeDetails
{
    public record GetTaskTypeDetailsQuery(int Id) : IRequest<TaskTypeDetailsDto>;
}
