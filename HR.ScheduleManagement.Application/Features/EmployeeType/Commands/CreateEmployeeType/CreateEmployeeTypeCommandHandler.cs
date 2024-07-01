using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Application.Exceptions;
using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Commands.CreateEmployeeType
{
    internal class CreateEmployeeTypeCommandHandler : IRequestHandler<CreateEmployeeTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeTypeRepository _employeeTypeRepository;

        public CreateEmployeeTypeCommandHandler(IMapper mapper, IEmployeeTypeRepository employeeTypeRepository)
        {
            this._mapper = mapper;
            this._employeeTypeRepository = employeeTypeRepository;
        }
        public async Task<int> Handle(CreateEmployeeTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateEmployeeTypeCommandValidator(_employeeTypeRepository);

            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Invalid Employeetype", validationResult);
            }

            var employeeTypeToCreate = _mapper.Map<Domain.EmployeeType>(request);

            await _employeeTypeRepository.CreateAsync(employeeTypeToCreate);

            return employeeTypeToCreate.Id;
        }
    }
}
