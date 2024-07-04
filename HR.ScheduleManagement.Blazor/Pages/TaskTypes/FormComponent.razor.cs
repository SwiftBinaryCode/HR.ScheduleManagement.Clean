using HR.ScheduleManagement.Blazor.Models.TaskTypes;
using Microsoft.AspNetCore.Components;

namespace HR.ScheduleManagement.Blazor.Pages.TaskTypes
{
    public partial class FormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public TaskTypeVM TaskType { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}