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
        DateTime dateOfRegistration { get; set; }
        bool isReliable { get; set; }

        public Client(bool _sex, DateTime _date)
        {
            this.sex = _sex;
            this.dateOfRegistration = _date;
            this.ID = IDCounter++;
        }
    }
}
