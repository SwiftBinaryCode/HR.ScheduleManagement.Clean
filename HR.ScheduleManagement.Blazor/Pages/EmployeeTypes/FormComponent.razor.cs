using HR.ScheduleManagement.Blazor.Models.EmployeeTypes;
using Microsoft.AspNetCore.Components;

namespace HR.ScheduleManagement.Blazor.Pages.EmployeeTypes
{
    public partial class FormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public EmployeeTypeVM EmployeeType { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}