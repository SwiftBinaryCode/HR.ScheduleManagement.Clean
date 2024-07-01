using HR.ScheduleManagement.BlazorUI.Models.EmployeeTypes;
using HR.ScheduleManagement.BlazorUI.Services.Base;

namespace HR.ScheduleManagement.BlazorUI.Contracts
{
    public interface IEmployeeTypeService
    {
        Task<List<EmployeeTypeVM>> GetEmployeeTypes();
        Task<EmployeeTypeVM> GetEmployeeTypeDetails(int id);
        Task<Response<Guid>> CreateEmployeeType(EmployeeTypeVM employeeType);
        Task<Response<Guid>> UpdateEmployeeType(int id, EmployeeTypeVM employeeType);
        Task<Response<Guid>> DeleteEmployeeType(int id);

    }
}
