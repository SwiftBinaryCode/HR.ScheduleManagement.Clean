using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Domain;
using HR.ScheduleManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.ScheduleManagement.Persistence.Repositories
{
    public class EmployeeTypeRepository : GenericRepository<EmployeeType>, IEmployeeTypeRepository
    {
        public EmployeeTypeRepository(HrDatabaseContext context) : base(context)
        {
        }

        public async Task<bool> IsEmployeeTypeUnique(string name)
        {
           return await _context.Employees.AnyAsync(q => q.Name == name) == false;
        }
    }
}
