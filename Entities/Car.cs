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
        public int ID { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string categoryID { get; set; }
        private FuelType fuel { get; set; }
        public short yearOfProduction { get; set; }

        private bool hasAutomaticTransmission { get; set; }
        private Image image { get; set; }
        private bool isOperated { get; set; }
        public bool isOccupied { get; set; }

        public Car(string _brand, string _model, string _categoryID, FuelType _fuel, short _yearOfProduction,
            bool _hasAutomaticTransmission, Image _image)
        {
            this.ID = IDCounter++;
            this.brand = _brand;
            this.model = _model;
            this.categoryID = _categoryID;
            this.fuel = _fuel;
            this.yearOfProduction = _yearOfProduction;
            this.hasAutomaticTransmission = _hasAutomaticTransmission;
            this.image = _image;
            this.isOccupied = false;
        }

        public Car(int _Id, string _brand, string _model, string _categoryID, FuelType _fuel, short _yearOfProduction,
          bool _hasAutomaticTransmission, Image _image, bool _isOccupied)
        {
            this.ID = _Id;
            this.brand = _brand;
            this.model = _model;
            this.categoryID = _categoryID;
            this.fuel = _fuel;
            this.yearOfProduction = _yearOfProduction;
            this.hasAutomaticTransmission = _hasAutomaticTransmission;
            this.image = _image;
            this.isOccupied = _isOccupied;

        }
    }
}
