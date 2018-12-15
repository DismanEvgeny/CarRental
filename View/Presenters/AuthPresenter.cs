using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace Presenrers.Presenters
{
    public class AuthPresenter
    {
        public static AbstractUser activeUser = null;

        public static bool authenticate(string login, string password)
        {
            AuthService authService = new AuthService();

            if (!authService.getUser(activeUser, login, password))
                return false;

            return true;
        }
    }
}
