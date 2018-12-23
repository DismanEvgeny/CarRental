using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IServices
{
    public interface IAuthService
    {
        Worker getUser(Worker user, string login, string password);
        bool checkLoginAndPasswordString(string login, string password);

    }
}
