using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client : AbstractPerson
    {

        public bool Sex { get; set; }
        public int Experience { get; set; }
        DateTime DateOfRegistration { get; set; }

        public Client(bool sex, int exp, DateTime date)
        {
            this.Sex = sex;
            this.Experience = exp;
            this.DateOfRegistration = date;
            this.ID = IDCounter++;
        }
    }
}
