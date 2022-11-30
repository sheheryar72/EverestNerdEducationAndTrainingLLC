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
        Tokens AuthenticateUserFromDB(string Email, string Password);
        int ContactUs(Contact contact);
        int EditCustomer(User user);
        User GetCustomerByEmail(string UserEmail);
        bool IsTokenValid(string key, string issuer, string token);
        int EditFooterInDB(Footer footer);
        Footer GetFooterById(int Id);
    }
}
