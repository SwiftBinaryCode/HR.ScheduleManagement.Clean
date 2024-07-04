using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.TaskType.Queries.GetAllTasksTypes
{
    public class GetTaskTypesQueryHandler : IRequestHandler<GetTaskTypesQuery, List<TaskTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ITaskTypeRepository _taskTypeRepository;

        public GetTaskTypesQueryHandler(IMapper mapper, ITaskTypeRepository taskTypeRepository)
        {
            this._mapper = mapper;
            this._taskTypeRepository = taskTypeRepository;
        }

        public async Task<List<TaskTypeDto>> Handle(GetTaskTypesQuery request, CancellationToken cancellationToken)
        {
            var taskTypes = await _taskTypeRepository.GetAsync();

            var data = _mapper.Map<List<TaskTypeDto>>(taskTypes);

            return data;
        }
    }
}
