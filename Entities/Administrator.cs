﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Administrator: AbstractUser
    {
        public Administrator(string name, string surname, string login, string password)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            SetPassword(password);
        }
    }
}
