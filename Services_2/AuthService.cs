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
        private IAuthRepository authRepository;

        public AuthService()
        {
            authRepository = new AuthRepository();
        }

        public AuthService(AuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        public bool checkLoginAndPasswordString(string login, string password)
        {
            if (login == null || password == null)
                return false;

            if (login.Length > 30 || password.Length > 30)
                return false;

            return true;
        }


        public Worker getUser(Worker active, string login, string password)
        {
            if (!checkLoginAndPasswordString(login, password))
            {
                Console.WriteLine("checkLoginAndPasswordString");
                return null;
            }

            AuthRepository authRepository = new AuthRepository();
            string[] str = authRepository.getUserFromDB(login);

            if (str[4] != password)
            {
                Console.WriteLine("password = " + str[4]);

                return null;
            }


            bool _isAdmin = (str[5] == "1" || str[5] == "True"); // перевод string в bool
            active = new Worker(str[1], str[2], str[3], str[4], _isAdmin);
            //Console.WriteLine("Worker: "+active.name+" "+active.surname);


            return active;
        }
    }
}