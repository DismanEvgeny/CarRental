using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Administrator: AbstractUser
    {
        public Administrator(string _name, string _surname, string _login, string _password)
        {
            this.login = _login;
            this.name = _name;
            this.surname = _surname;
            this.password = _password;
        }
    }
}
