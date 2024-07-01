using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Application.Exceptions;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetEmployeeTypeDetails
{
    public class GetEmployeeTypeDetailsQueryHandler : IRequestHandler<GetEmployeeTypeDetailsQuery, EmployeeTypeDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeTypeRepository _employeeTypeRepository;

        public GetEmployeeTypeDetailsQueryHandler(IMapper mapper, IEmployeeTypeRepository employeeTypeRepository)
        {
            this._mapper = mapper;
            this._employeeTypeRepository = employeeTypeRepository;
        }

        public async Task<EmployeeTypeDetailsDto> Handle(GetEmployeeTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var employeeTypes = await _employeeTypeRepository.GetByIdAsync(request.Id);

            if (employeeTypes == null)
                throw new NotFoundException(nameof(EmployeeType), request.Id);

            var data = _mapper.Map<EmployeeTypeDetailsDto>(employeeTypes);

            return data;
        }
    }
}
