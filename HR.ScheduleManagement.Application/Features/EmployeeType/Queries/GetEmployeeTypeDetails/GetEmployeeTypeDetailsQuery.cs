using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetEmployeeTypeDetails
{
    public record GetEmployeeTypeDetailsQuery(int Id) : IRequest<EmployeeTypeDetailsDto>;
    
}
