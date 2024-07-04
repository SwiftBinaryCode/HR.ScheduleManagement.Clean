using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Application.Exceptions;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Commands.DeleteTaskType
{
    public class DeleteTaskTypeCommandHandler : IRequestHandler<DeleteTaskTypeCommand, Unit>
    {
        private readonly ITaskTypeRepository _taskTypeRepository;

        public DeleteTaskTypeCommandHandler(ITaskTypeRepository taskTypeRepository)
        {
            this._taskTypeRepository = taskTypeRepository;
        }
        public async Task<Unit> Handle(DeleteTaskTypeCommand request, CancellationToken cancellationToken)
        {
            var taskTypeToDelete = await _taskTypeRepository.GetByIdAsync(request.Id);

            if (taskTypeToDelete == null)
                throw new NotFoundException(nameof(TaskType), request.Id);


            await _taskTypeRepository.DeleteAsync(taskTypeToDelete);

            return Unit.Value;
        }
    }
}
