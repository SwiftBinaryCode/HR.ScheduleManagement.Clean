using HR.ScheduleManagement.Domain;

namespace HR.ScheduleManagement.Application.Contracts.Persistence
{
    public interface IEmployeeTypeRepository : IGenericRepository<EmployeeType> 
    {
        Task<bool> IsEmployeeTypeUnique(string name);
    }
}
