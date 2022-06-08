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
    public class CustomerFeedBackRepository : ICustomerFeedBackRepository
    {
        private readonly IDbConnection conn;
        public CustomerFeedBackRepository(IDbConnection dbConnection)
        {
            conn = dbConnection;
        }
        public List<ClientFeedBack> GetClientFeedBacks()
        {
            string query = "Select * from ClientFeedBack;";
            var _parameter = new Dictionary<string, object>();
            List<ClientFeedBack> result = conn.Query<ClientFeedBack>(query, param: _parameter, commandType: CommandType.Text).ToList();
            return result;
        }
    }
}
