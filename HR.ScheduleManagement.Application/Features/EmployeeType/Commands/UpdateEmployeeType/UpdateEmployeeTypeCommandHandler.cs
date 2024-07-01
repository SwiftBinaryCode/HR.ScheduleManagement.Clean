using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Application.Features.EmployeeType.Commands.CreateEmployeeType;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Commands.UpdateEmployeeType
{
    public class UpdateEmployeeTypeCommandHandler : IRequestHandler<UpdateEmployeeTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeTypeRepository _employeeTypeRepository;

        public UpdateEmployeeTypeCommandHandler(IMapper mapper, IEmployeeTypeRepository employeeTypeRepository)
        {
            this._mapper = mapper;
            this._employeeTypeRepository = employeeTypeRepository;
        }
        public async Task<Unit> Handle(UpdateEmployeeTypeCommand request, CancellationToken cancellationToken)
        {




            var employeeTypeToUpdate = _mapper.Map<Domain.EmployeeType>(request);

            await _employeeTypeRepository.UpdateAsync(employeeTypeToUpdate);


            return Unit.Value;
        }
    }
}
