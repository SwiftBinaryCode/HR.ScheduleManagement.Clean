using HR.ScheduleManagement.Blazor.Contracts;
using HR.ScheduleManagement.Blazor.Models.EmployeeTypes;
using Microsoft.AspNetCore.Components;

namespace HR.ScheduleManagement.Blazor.Pages.EmployeeTypes
{
    public partial class Create
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        IEmployeeTypeService _client { get; set; }
        public string Message { get; private set; }

        EmployeeTypeVM employeeType = new EmployeeTypeVM();
        async Task CreateEmployeeType()
        {
            var response = await _client.CreateEmployeeType(employeeType);
            if (response.Success)
            {
                NavigationManager.NavigateTo("/employeetypes/");
            }
            Message = response.Message;
        }
    }
}