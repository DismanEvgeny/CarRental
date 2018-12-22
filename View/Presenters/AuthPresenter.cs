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
        //public static AbstractUser activeUser = null;

        public static AbstractUser authenticate (AbstractUser active, string login, string password)
        {
            AuthService authService = new AuthService();
            active = authService.getUser(active, login, password);
            if (active == null)
                return null;

            return active;
        }
    }
}
