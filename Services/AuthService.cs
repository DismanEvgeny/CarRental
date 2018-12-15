using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using IServices;
using Repositories;
using IRepositories;

namespace Services
{
    public class AuthService : IAuthService
    {
        public bool checkLoginAndPasswordString(string login, string password)
        {
            if (login == null || password == null)
                return false;

            if (login.Length > 20 || password.Length > 20)
                return false;

            return true;
        }


        public bool getUser(AbstractUser user, string login, string password)
        {
            if (!checkLoginAndPasswordString(login, password))
            {
                Console.WriteLine("checkLoginAndPasswordString");
                return false;
            }

            AuthRepository authRepository = new AuthRepository();
            string[] str = authRepository.getUserFromDB(login);

            if (str[4] != password)
            {
                Console.WriteLine("password = " + str[4]);

                return false;
            }


            return true;
        }
    }
}