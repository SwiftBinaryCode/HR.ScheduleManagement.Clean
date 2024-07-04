using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Commands.DeleteTaskType
{
    public class DeleteTaskTypeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}

