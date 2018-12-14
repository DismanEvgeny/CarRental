using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;

namespace Repositories
{
    class AuthRepository : IAuthRepository
    {
        string[] IAuthRepository.getUserFromDB(string login)
        {
            //throw new NotImplementedException();
            string[] userString = null;

            DataBaseUtils dataBaseUtils = new DataBaseUtils();

            userString = dataBaseUtils.getUsersFromDB(login);

            return userString;

        }
    }
}
