﻿using System;
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
            this.ID = _ID;
            this.name = _name;
            this.tariff = _tariff;
            this.fine = _fine;

        }
    }
}
