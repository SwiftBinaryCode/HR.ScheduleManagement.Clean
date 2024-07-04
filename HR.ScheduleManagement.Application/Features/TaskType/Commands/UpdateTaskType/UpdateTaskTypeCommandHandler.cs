using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Commands.UpdateTaskType
{
    public class UpdateTaskTypeCommandHandler : IRequestHandler<UpdateTaskTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ITaskTypeRepository _taskTypeRepository;

        public UpdateTaskTypeCommandHandler(IMapper mapper, ITaskTypeRepository taskTypeRepository)
        {
            this._mapper = mapper;
            this._taskTypeRepository = taskTypeRepository;
        }
        public async Task<Unit> Handle(UpdateTaskTypeCommand request, CancellationToken cancellationToken)
        {
            var taskTypeToUpdate = _mapper.Map<Domain.TaskType>(request);

            await _taskTypeRepository.UpdateAsync(taskTypeToUpdate);

            return Unit.Value;
        }
    }
}
