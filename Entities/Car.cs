using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using Entities.FuelType;


namespace Entities
{
    public class Car
    {
        static int IDCounter = 0;
        private int ID { get; set; }
        private string brand { get; set; }
        private string model { get; set; }
        private string categoryID { get; set; }
        private FuelType fuel { get; set; }
        private short yearOfProduction { get; set; }
        private DateTime dateOfInsurance { get; set; }
        private DateTime dateOfInsuranceEnd { get; set; }
        private bool hasAutomaticTransmission { get; set; }
        private Image image { get; set; }
        private bool isOperated { get; set; }


        public Car(string _brand, string _model, string _categoryID, FuelType _fuel, short _yearOfProduction, DateTime _dateOfInsurance, DateTime _dateOfInsuranceEnd,
            bool _hasAutomaticTransmission, Image _image)
        {
            this.ID = IDCounter++;
            this.brand = _brand;
            this.model = _model;
            this.categoryID = _categoryID;
            this.fuel = _fuel;
            this.yearOfProduction = _yearOfProduction;
            this.dateOfInsurance = _dateOfInsurance;
            this.dateOfInsuranceEnd = _dateOfInsuranceEnd;
            this.hasAutomaticTransmission = _hasAutomaticTransmission;
            this.image = _image;
        }

        public Car(int _Id, string _brand, string _model, string _categoryID, FuelType _fuel, short _yearOfProduction, DateTime _dateOfInsurance, DateTime _dateOfInsuranceEnd,
          bool _hasAutomaticTransmission, Image _image)
        {
            this.ID = _Id;
            this.brand = _brand;
            this.model = _model;
            this.categoryID = _categoryID;
            this.fuel = _fuel;
            this.yearOfProduction = _yearOfProduction;
            this.dateOfInsurance = _dateOfInsurance;
            this.dateOfInsuranceEnd = _dateOfInsuranceEnd;
            this.hasAutomaticTransmission = _hasAutomaticTransmission;
            this.image = _image;
        }
    }
}
