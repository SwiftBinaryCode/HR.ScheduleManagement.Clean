using Microsoft.AspNetCore.Mvc;

namespace HR.ScheduleManagement.Api.Models
{
    public class CustomProblemDetails : ProblemDetails
    {
        public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    }
}
