using Microsoft.AspNetCore.Http;

namespace EverestNerdEducationAndTrainingLLC.Models
{
    public class ApplyJobs
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string AppliedFor { get; set; }
        public string Message { get; set; }
        public string Experience { get; set; }
        public IFormFile CV { get; set; }
        public int JobId { get; set; }
    }
}
