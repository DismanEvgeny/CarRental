using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Entities.FuelType;


namespace Entities
{
    class Car
    {
        static int IDCounter = 0;
        private int ID { get; set; }
        private string brand { get; set; }
        private string categoryID { get; set; }
        private FuelType fuel { get; set; }
        private short yearOfProduction { get; set; }
        private DateTime dateOfInsurance { get; set; }
        private DateTime dateOfInsuranceEnd { get; set; }
        private bool hasAutomaticTransmission { get; set; }
        //private Image image { get; set;}
        private bool isOperated { get; set; }


        public Car(string _brand, string _categoryID, FuelType _fuel, short _yearOfProduction,
            bool _hasAutomaticTransmission/*, Image _image*/)
        {
            this.ID = IDCounter++;
            this.brand = _brand;
            this.categoryID = _categoryID;
            this.fuel = _fuel;
            this.yearOfProduction = _yearOfProduction;
            this.hasAutomaticTransmission = _hasAutomaticTransmission;
            // this.image = _image;
        }
    }
}
