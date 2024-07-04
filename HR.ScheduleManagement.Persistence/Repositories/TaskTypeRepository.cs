using HR.ScheduleManagement.Application.Contracts.Persistence;
using HR.ScheduleManagement.Domain;
using HR.ScheduleManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.ScheduleManagement.Persistence.Repositories
{
    public class TaskTypeRepository : GenericRepository<TaskType>, ITaskTypeRepository
    {
        public TaskTypeRepository(HrDatabaseContext context) : base(context)
        {
            
        }

        public async Task<bool> IsTaskTypeUnique(string name)
        {
            return await _context.Tasks.AnyAsync(q => q.Title == name) == false;
        }
    }
}
