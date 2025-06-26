using AutoMapper;
using Blazored.LocalStorage;
using HR.ScheduleManagement.Blazor.Contracts;
using HR.ScheduleManagement.Blazor.Models.TaskTypes;
using HR.ScheduleManagement.Blazor.Services.Base;

namespace HR.ScheduleManagement.Blazor.Services
{
    public class TaskTypeService : BaseHttpService, ITaskTypeService
    {
        private readonly IMapper _mapper;

        public TaskTypeService(IClient client, IMapper mapper, ILocalStorageService localStorageService) : base(client, localStorageService)
        {
            this._mapper = mapper;
        }

        public async Task<Response<Guid>> CreateTaskType(TaskTypeVM taskType)
        {
            try
            {
                var createTaskTypeCommand = _mapper.Map<CreateTaskTypeCommand>(taskType);
                await _client.TasksPOSTAsync(createTaskTypeCommand);
                return new Response<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> DeleteTaskType(int id)
        {
            try
            {

                await _client.TasksDELETEAsync(id);
                return new Response<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<TaskTypeVM> GetTaskTypeDetails(int id)
        {
            var taskType = await _client.TasksGETAsync(id);
            return _mapper.Map<TaskTypeVM>(taskType);
        }

        public async Task<List<TaskTypeVM>> GetTaskTypes()
        {
            var tasktypes = await _client.TasksAllAsync();
            return _mapper.Map<List<TaskTypeVM>>(tasktypes);
        }

        public async Task<Response<Guid>> UpdateTaskType(int id, TaskTypeVM taskType)
        {
            try
            {
                var updateTaskTypeCommand = _mapper.Map<UpdateTaskTypeCommand>(taskType);
                await _client.TasksPUTAsync(id.ToString(), updateTaskTypeCommand);
                return new Response<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}
