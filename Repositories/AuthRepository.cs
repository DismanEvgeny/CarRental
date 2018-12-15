using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;

namespace Repositories
{
    public class AuthRepository : IAuthRepository
    {
        public string[] getUserFromDB(string login)
        {
            //throw new NotImplementedException();
            string[] userString = null;

            DataBaseUtils dataBaseUtils = new DataBaseUtils();

            userString = dataBaseUtils.getUsersFromDB(login);

            return userString;

        }
    }
}