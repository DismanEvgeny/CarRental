using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    abstract public class AbstractPerson
    {
        public static int IDCounter = 0;
        //поля
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public int ID { get; } = IDCounter++; //ID будут присваиваться по порядку создания объектов

    }
}
