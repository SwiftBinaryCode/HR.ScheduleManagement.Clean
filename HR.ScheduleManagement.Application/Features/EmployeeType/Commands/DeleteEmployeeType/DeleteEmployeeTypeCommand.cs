using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Commands.DeleteEmployeeType
{
    public class DeleteEmployeeTypeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
