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
        public bool Experience { get; set; }
        DateTime dateOfRegistration { get; set; }
    }
}
