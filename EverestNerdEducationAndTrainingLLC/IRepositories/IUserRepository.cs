using EverestNerdEducationAndTrainingLLC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.IRepositories
{
    public interface IUserRepository
    {
        int AddCustomer(User user);
        bool AuthenticateUserFromDB(string Email, string Password);
        int ContactUs(Contact contact);
        int EditCustomer(User user);
        User GetCustomerByEmail(string UserEmail);
    }
}
