using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Application.Exceptions;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Queries.GetTaskTypeDetails
{

    public class GetTaskTypeDetailsQueryHandler : IRequestHandler<GetTaskTypeDetailsQuery, TaskTypeDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly ITaskTypeRepository _taskTypeRepository;

        public GetTaskTypeDetailsQueryHandler(IMapper mapper, ITaskTypeRepository taskTypeRepository)
        {
            this._mapper = mapper;
            this._taskTypeRepository = taskTypeRepository;
        }


        public async Task<TaskTypeDetailsDto> Handle(GetTaskTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var taskTypes = await _taskTypeRepository.GetByIdAsync(request.Id);

            if (taskTypes == null)
                throw new NotFoundException(nameof(TaskType), request.Id);

            var data = _mapper.Map<TaskTypeDetailsDto>(taskTypes);

            return data;
        }
    }
}
