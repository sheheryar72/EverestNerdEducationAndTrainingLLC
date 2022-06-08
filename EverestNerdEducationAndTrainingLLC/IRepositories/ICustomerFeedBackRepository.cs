using EverestNerdEducationAndTrainingLLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.IRepositories
{
    public interface ICustomerFeedBackRepository
    {
        List<ClientFeedBack> GetClientFeedBacks();
    }
}
