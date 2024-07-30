using System.ComponentModel.DataAnnotations;

namespace HR.ScheduleManagement.Blazor.Models.EmployeeTypes
{
    public class EmployeeTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        
        public string Task { get; set; }

        public string secondTask { get; set; } = string.Empty;

        public string extraTask { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

    }
}
