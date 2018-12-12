using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    abstract public class AbstractPerson
    {
        public static int IDCounter = 0; //счётчик ID общий и для работников, и для клиентов, и для администратораЫ
        //поля
        public string name { get; set; }
        public string surname { get; set; }
        public int ID { get; set; } //ID будут присваиваться по порядку создания объектов

    }
}
