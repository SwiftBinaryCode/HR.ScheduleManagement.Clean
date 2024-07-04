using System.ComponentModel.DataAnnotations;

namespace HR.ScheduleManagement.Blazor.Models.TaskTypes
{
    public class TaskTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
    }
}
