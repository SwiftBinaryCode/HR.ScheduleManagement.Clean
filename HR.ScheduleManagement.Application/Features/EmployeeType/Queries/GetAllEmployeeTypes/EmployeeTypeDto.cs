namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetAllEmployeeTypes
{
    public class EmployeeTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Position { get; set; }

        public string Task { get; set; } = string.Empty;

    }
}
