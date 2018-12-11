using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Category
    {
        private string ID { get; set; }
        private string name { get; set; }
        private float tariff { get; set; } 
        private float fine { get; set; }

        public Category(string _ID, string _name, float _tariff, float _fine)
        {
            setID(_ID);
            setName(_name);
            setTariff(_tariff);
            setFine(_fine);
        }

        protected void setID(string _ID)
        {
            this.ID = _ID;
        }

        protected string getID()
        {
            return this.ID;
        }

        protected void setName(string _name)
        {
            this.name = _name;
        }

        protected string getName()
        {
            return this.name;
        }

        protected void setTariff(float _tariff)
        {
            this.tariff = _tariff;
        }

        protected float getTariff()
        {
            return this.tariff;
        }

        protected void setFine(float _fine)
        {
            this.fine = _fine;
        }

        protected float getFine()
        {
            return this.fine;
        }
    }
}
