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
        public string login { get; set; }

        public string password { get; set; }

        //методы



    }
}
