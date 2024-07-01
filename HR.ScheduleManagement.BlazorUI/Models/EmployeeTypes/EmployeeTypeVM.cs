using System.ComponentModel.DataAnnotations;

namespace HR.ScheduleManagement.BlazorUI.Models.EmployeeTypes
{
    public class EmployeeTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }
    }
}
