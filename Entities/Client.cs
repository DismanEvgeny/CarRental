using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client : AbstractPerson
    {

        public bool sex { get; set; }
        public int experience { get; set; }
        DateTime dateOfRegistration { get; set; }

        public Client(bool _sex, int _exp, DateTime _date)
        {
            this.sex = _sex;
            this.experience = _exp;
            this.dateOfRegistration = _date;
            this.ID = IDCounter++;
        }
    }
}
