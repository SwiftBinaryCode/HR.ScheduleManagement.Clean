using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Commands.CreateTaskType
{
    public class CreateTaskTypeCommand : IRequest<int>
    {
        public string Title { get; set; } = string.Empty;
    }
}
