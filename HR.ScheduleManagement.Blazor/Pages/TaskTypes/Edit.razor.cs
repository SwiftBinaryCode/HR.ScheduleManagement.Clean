using HR.ScheduleManagement.Blazor.Contracts;
using HR.ScheduleManagement.Blazor.Models.TaskTypes;
using Microsoft.AspNetCore.Components;

namespace HR.ScheduleManagement.Blazor.Pages.TaskTypes
{
    public partial class Edit
    {
        [Inject]
        ITaskTypeService _client { get; set; }

        [Inject]
        NavigationManager _navManager { get; set; }

        [Parameter]
        public int id { get; set; }
        public string Message { get; private set; }

        TaskTypeVM taskType = new TaskTypeVM();

        protected async override Task OnParametersSetAsync()
        {
            taskType = await _client.GetTaskTypeDetails(id);
        }

        async Task EditTaskType()
        {
            var response = await _client.UpdateTaskType(id, taskType);
            if (response.Success)
            {
                _navManager.NavigateTo("/tasktypes/");
            }
            Message = response.Message;
        }

    }
}