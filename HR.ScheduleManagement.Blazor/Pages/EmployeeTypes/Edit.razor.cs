using HR.ScheduleManagement.Blazor.Contracts;
using HR.ScheduleManagement.Blazor.Models.EmployeeTypes;
using Microsoft.AspNetCore.Components;

namespace HR.ScheduleManagement.Blazor.Pages.EmployeeTypes
{
    public partial class Edit
    {
        [Inject]
        IEmployeeTypeService _client { get; set; }

        [Inject]
        NavigationManager _navManager { get; set; }

        [Parameter]
        public int id { get; set; }
        public string Message { get; private set; }

        EmployeeTypeVM employeeType = new EmployeeTypeVM();

        protected async override Task OnParametersSetAsync()
        {
            employeeType = await _client.GetEmployeeTypeDetails(id);
        }

        async Task EditEmployeeType()
        {
            var response = await _client.UpdateEmployeeType(id, employeeType);
            if (response.Success)
            {
                _navManager.NavigateTo("/employeetypes/");
            }
            Message = response.Message;
        }
    }
}