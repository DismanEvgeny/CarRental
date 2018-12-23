using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Worker : AbstractPerson
    {
        public string login { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
        public Worker(string _name, string _surname, string _login, string _password, bool _isAdmin)
        {
            this.login = _login;
            this.name = _name;
            this.surname = _surname;
            this.password = _password;
            this.isAdmin = _isAdmin;
        }
    }
}
