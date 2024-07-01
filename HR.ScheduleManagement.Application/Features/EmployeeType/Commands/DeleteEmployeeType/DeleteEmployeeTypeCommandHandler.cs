using AutoMapper;
using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Commands.DeleteEmployeeType
{
    public class DeleteEmployeeTypeCommandHandler : IRequestHandler<DeleteEmployeeTypeCommand, Unit>
    {
      
        private readonly IEmployeeTypeRepository _employeeTypeRepository;

        public DeleteEmployeeTypeCommandHandler(IEmployeeTypeRepository employeeTypeRepository)
        {
            this._employeeTypeRepository = employeeTypeRepository;
        }
        public async Task<Unit> Handle(DeleteEmployeeTypeCommand request, CancellationToken cancellationToken)
        {
            var employeeTypeToDelete = await _employeeTypeRepository.GetByIdAsync(request.Id);

            if (employeeTypeToDelete == null)
                throw new NotFoundException(nameof(EmployeeType), request.Id);


            await _employeeTypeRepository.DeleteAsync(employeeTypeToDelete);

            return Unit.Value;
        }
    }
}
