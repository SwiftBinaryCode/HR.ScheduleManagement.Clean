using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetEmployeeTypeDetails
{
    public class EmployeeTypeDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Position { get; set; }

    }
}
