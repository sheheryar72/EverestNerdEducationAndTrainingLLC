using Dapper;
using EverestNerdEducationAndTrainingLLC.IRepositories;
using EverestNerdEducationAndTrainingLLC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EverestNerdEducationAndTrainingLLC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection conn;
        public UserRepository(IDbConnection dbConnection)
        {
            conn = dbConnection;
        }
        public int AddCustomer(User user)
        {
            string query = "Insert into [User] Values(@UserName, @Email, @Age, @Grade, @ContactNo, @Password, @Interestofstudy) SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@UserName", user.UserName);
            _parameter.Add("@Email", user.Email);
            _parameter.Add("@Age", user.Age);
            _parameter.Add("@Grade", user.Grade);
            _parameter.Add("@Interestofstudy", user.Interestofstudy);
            _parameter.Add("@ContactNo", user.ContactNo);
            _parameter.Add("@Password", user.Password);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public bool AuthenticateUserFromDB(string Email, string Password)
        {
            try
            {
                string query = "Select * from [User] where Email = @Email and Password = @Password";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("Email", Email);
                _parameter.Add("Password", Password);
                User result = conn.Query<User>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                if (result != null)
                {
                    if (result.Email == Email && result.Password == Password)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int ContactUs(Contact contact)
        {
            string query = "Insert into [Contact] Values(@Name, @Email, @Subject, @Phone, @Message) SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Name", contact.Name);
            _parameter.Add("@Email", contact.Email);
            _parameter.Add("@Subject", contact.Subject);
            _parameter.Add("@Phone", contact.Phone);
            _parameter.Add("@Message", contact.Message);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public int EditCustomer(User user)
        {
            string query = "Update [User] Set UserName = @UserName, Email = @Email, Age = @Age, Grade = @Grade, Interestofstudy = @Interestofstudy, ContactNo = @ContactNo, Password = @Password Where Email = @Email SELECT @Age";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@UserName", user.UserName);
            _parameter.Add("@Email", user.Email);
            _parameter.Add("@Age", user.Age);
            _parameter.Add("@Grade", user.Grade);
            _parameter.Add("@Interestofstudy", user.Interestofstudy);
            _parameter.Add("@ContactNo", user.ContactNo);
            _parameter.Add("@Password", user.Password);
            var result = conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
        public User GetCustomerByEmail(string UserEmail)
        {
            string query = "Select * from [User] where Email = @Email";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("Email", UserEmail);
            User result = conn.Query<User>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
    }
}
