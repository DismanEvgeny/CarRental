using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    abstract public class AbstractUser : AbstractPerson
    {
        //поля
        public string Login { get; protected set; }

        private string Password;

        //методы
        protected string GetPassword()
        {
            return Password;
        }

        protected void SetPassword(string password)
        {
            Password = password;
        }


    }
}
