using MediatR;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetAllEmployeeTypes
{
    public record GetEmployeeTypesQuery : IRequest<List<EmployeeTypeDto>>;
    
}
