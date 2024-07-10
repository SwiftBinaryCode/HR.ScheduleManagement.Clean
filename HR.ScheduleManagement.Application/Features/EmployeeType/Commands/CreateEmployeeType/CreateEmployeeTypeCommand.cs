using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Commands.CreateEmployeeType
{
    public class CreateEmployeeTypeCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;

        public string Task { get; set; } = string.Empty;

        public string secondTask {  get; set; } = string.Empty;

    }
}
