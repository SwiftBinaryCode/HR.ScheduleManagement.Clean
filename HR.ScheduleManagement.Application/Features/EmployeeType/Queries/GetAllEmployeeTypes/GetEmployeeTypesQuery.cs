using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetAllEmployeeTypes
{
    public record GetEmployeeTypesQuery : IRequest<List<EmployeeTypeDto>>;
    
}
