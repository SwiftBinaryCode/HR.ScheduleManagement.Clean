using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Application.Exceptions;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Commands.CreateTaskType
{
    public class CreateTaskTypeCommandHandler : IRequestHandler<CreateTaskTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ITaskTypeRepository _taskTypeRepository;

        public CreateTaskTypeCommandHandler(IMapper mapper, ITaskTypeRepository taskTypeRepository)
        {
            this._mapper = mapper;
            this._taskTypeRepository = taskTypeRepository;
        }
        public async Task<int> Handle(CreateTaskTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateTaskTypeCommandValidator(_taskTypeRepository);

            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Invalid Tasktype", validationResult);
            }

            var taskTypeToCreate = _mapper.Map<Domain.TaskType>(request);

            await _taskTypeRepository.CreateAsync(taskTypeToCreate);

            return taskTypeToCreate.Id;
        }
    }
}
