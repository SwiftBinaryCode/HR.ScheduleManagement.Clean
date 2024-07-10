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

        [Required]
        public string Task { get; set; }

        [Required]
        public string secondTask { get; set; } = string.Empty;


    }
}
