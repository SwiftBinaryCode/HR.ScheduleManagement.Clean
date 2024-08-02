using System.ComponentModel.DataAnnotations;

namespace HR.ScheduleManagement.Blazor.Models.EmployeeTypes
{
    public class EmployeeTypeVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Position { get; set; } = string.Empty;

        
        public string Task { get; set; } = string.Empty;

        public string secondTask { get; set; } = string.Empty;

        public string extraTask { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

    }
}
