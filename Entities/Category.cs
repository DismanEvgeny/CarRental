using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        
        public string ID { get; set; }
        private string name { get; set; }
        public float tariff { get; set; } 
        public float fine { get; set; }

        public Category(string _ID, string _name, float _tariff, float _fine)
        {
            this.ID = _ID;
            this.name = _name;
            this.tariff = _tariff;
            this.fine = _fine;

        }

        public string getID()
        {
            return ID;
        }

        public float getTarif()
        {
            return tariff;
        }

        public float getFine()
        {
            return fine;
        }

        public string getName()
        {
            return name;
        }
    }
}
