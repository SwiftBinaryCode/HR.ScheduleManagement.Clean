namespace HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetEmployeeTypeDetails
{
    public class EmployeeTypeDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;

        public string Task { get; set; } = string.Empty;

        public string secondTask { get; set; } = string.Empty;

        public string extraTask { get; set; }

        public string Status { get; set; } 


    }
}
