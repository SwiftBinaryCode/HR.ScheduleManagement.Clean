using HR.ScheduleManagement.Domain.Common;

namespace HR.ScheduleManagement.Domain
{
    public class EmployeeType : BaseEntity
    {
    
        public string Name { get; set; }
        
        public string Position { get; set; }

        public string Task { get; set; }

        public string secondTask { get; set; }


    }
}
