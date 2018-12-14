using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
