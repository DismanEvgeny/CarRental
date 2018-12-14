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
        bool getUser(AbstractUser user, string login, string password);
        bool checkString(string str);

    }
}
