using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetAllEmployeeTypes
{
    public class GetEmployeeTypesQueryHandler : IRequestHandler<GetEmployeeTypesQuery, List<EmployeeTypeDto>>
    {
        private readonly IMapper _mapper;
        public readonly IEmployeeTypeRepository _employeeTypeRepository;
        public GetEmployeeTypesQueryHandler(IMapper mapper,IEmployeeTypeRepository employeeTypeRepository)
        {
            _mapper = mapper;
            _employeeTypeRepository = employeeTypeRepository;
        }

       

        public async Task<List<EmployeeTypeDto>> Handle(GetEmployeeTypesQuery request, CancellationToken cancellationToken)
        {
            var employeeTypes = await _employeeTypeRepository.GetAsync();

            var data = _mapper.Map<List<EmployeeTypeDto>>(employeeTypes);

            return data;
        }
    }
}
