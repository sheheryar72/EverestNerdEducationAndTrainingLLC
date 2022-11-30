using EverestNerdEducationAndTrainingLLC.Models;
using System.Collections.Generic;

namespace EverestNerdEducationAndTrainingLLC.IRepositories
{
    public interface IJobRepository
    {
        List<Jobs> GetJobs();
        int AppliedJob(ApplyJobs applyJobs);
        int AddJobs(Jobs jobs);
        List<ApplyJobs> GetAppliedJobs();
        bool FindAdmin(string Email);
        void DeleteJobs(int Id);
        int EditJob(Jobs jobs);
        void DeleteJob(int? Id);
        Jobs GetSingleJob(int? Id);
        List<ApplyJobs> GetAllApplyJobs();
        List<Contact> GetAllContactList();
    }
}
