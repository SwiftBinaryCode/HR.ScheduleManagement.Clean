using HR.ScheduleManagement.Domain;

namespace HR.ScheduleManagement.Application.Contracts.Persistence
{
    public interface ITaskTypeRepository : IGenericRepository<TaskType>
    {
        Task<bool> IsTaskTypeUnique(string name);
    }
}
