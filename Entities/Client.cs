using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client : AbstractPerson
    {
       // public string name { get; set; }
        public bool sex { get; set; }
        DateTime dateOfRegistration { get; set; }
        bool isReliable { get; set; }

        public Client(int _id, string _name, string _surname, bool _sex, DateTime _date)
        {
            this.name = _name;
            this.surname = _surname;
            this.sex = _sex;
            this.dateOfRegistration = _date;
            this.ID = _id;
        }
    }
}
