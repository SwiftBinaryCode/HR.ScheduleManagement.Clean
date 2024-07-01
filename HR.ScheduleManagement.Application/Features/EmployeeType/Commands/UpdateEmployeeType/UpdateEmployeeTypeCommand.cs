using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Commands.UpdateEmployeeType
{
    public class UpdateEmployeeTypeCommand : IRequest<Unit>
    {
        public string Name { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;
    }
}
