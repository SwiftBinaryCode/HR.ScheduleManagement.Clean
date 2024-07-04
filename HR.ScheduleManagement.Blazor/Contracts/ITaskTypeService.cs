using HR.ScheduleManagement.Blazor.Models.TaskTypes;
using HR.ScheduleManagement.Blazor.Services.Base;

namespace HR.ScheduleManagement.Blazor.Contracts
{
    public interface ITaskTypeService
    {
        Task<List<TaskTypeVM>> GetTaskTypes();
        Task<TaskTypeVM> GetTaskTypeDetails(int id);
        Task<Response<Guid>> CreateTaskType(TaskTypeVM taskType);
        Task<Response<Guid>> UpdateTaskType(int id, TaskTypeVM taskType);
        Task<Response<Guid>> DeleteTaskType(int id);
    }
}
