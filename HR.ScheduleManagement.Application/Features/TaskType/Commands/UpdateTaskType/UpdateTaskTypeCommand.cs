using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Commands.UpdateTaskType
{
    public class UpdateTaskTypeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

    }
}
