using FluentValidation;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Commands.CreateEmployeeType
{
    public class CreateEmployeeTypeCommandValidator : AbstractValidator<CreateEmployeeTypeCommand>
    {
        private readonly IEmployeeTypeRepository _employeeTypeRepository;

        public CreateEmployeeTypeCommandValidator(IEmployeeTypeRepository employeeTypeRepository)
        {

            _employeeTypeRepository = employeeTypeRepository;

            RuleFor(p => p.Name)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull()
             .MaximumLength(70).WithMessage("{PropertyName} must be fewer than 70 characters");


            RuleFor(q => q)
           .MustAsync(EmployeeTypeNameUnique)
           .WithMessage("Leave type already exists");
        }

        private Task<bool> EmployeeTypeNameUnique(CreateEmployeeTypeCommand command, CancellationToken token)
        {
            return _employeeTypeRepository.IsEmployeeTypeUnique(command.Name);
        }

    }
}
