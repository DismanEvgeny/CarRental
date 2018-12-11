using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    class Car
    {
        private int ID { get; set; }
        private string brand { get; set; }
        private string categoryID { get; set; }
        //private FuelType fuel { get; set; }
        private short yearOfProduction { get; set; }
        private DateTime dateOfInsurance { get; set; }
        private DateTime dateOfInsuranceEnd { get; set; }
        private bool hasAutomaticTransmission { get; set; }
        //private Image image { get; set;}
        private bool isOperated { get; set; }


        public Car(int _ID, string _brand, string _categoryID, /*FuelType _fuel,*/ short _yearOfProduction, 
            bool _hasAutomaticTransmission/*, Image _image*/)
        {
            setID(_ID);
            setBrand(_brand);
            setCategoryID(_categoryID);
            //setFuel(_fuel);
            setYearOFProduction(_yearOfProduction);
            setTransmission(_hasAutomaticTransmission);
            //setImage(_image);
        }

        protected void setID(int _ID)
        {
            this.ID = _ID;
        }

        protected int getID()
        {
            return this.ID;
        }

        protected void setBrand(string _brand)
        {
            this.brand = _brand;
        }

        protected string getBrand()
        {
            return this.brand;
        }

        protected void setCategoryID(string _categoryID)
        {
            this.categoryID = _categoryID;
        }

        protected string getCategoryID()
        {
            return this.categoryID;
        }

        protected void setYearOFProduction(short _yearOfProduction)
        {
            this.yearOfProduction = _yearOfProduction;
        }

        protected short getYearOFProduction()
        {
            return this.yearOfProduction;
        }

        protected void setDateOfInsurance(DateTime _dateOfInsurance)
        {
            this.dateOfInsurance = _dateOfInsurance;
        }

        protected DateTime getDateOfInsurance()
        {
            return this.dateOfInsurance;
        }

        protected void setDateOfInsuranceEnd(DateTime _dateOfInsuranceEnd)
        {
            this.dateOfInsuranceEnd = _dateOfInsuranceEnd;
        }

        protected DateTime getDateOfInsuranceEnd()
        {
            return this.dateOfInsuranceEnd;
        }

        protected void setTransmission(bool _hasAutomaticTransmission)
        {
            this.hasAutomaticTransmission = _hasAutomaticTransmission;
        }

        protected bool getTransmission()
        {
            return this.hasAutomaticTransmission;
        }


        /*protected void setImage(Image _image)
        {
            this.image = _image;
        }*/


        /*protected Image getImage()
        {
            return this.image;
        }*/

        /*protected void setFuel(FuelType _fuel)
        {
            this.fuel = _fuel;
        }*/

        /*protected FuelType getFuel()
        {
            return this.fuel;
        }*/

        protected void setState(bool _isOperated)
        {
            this.isOperated = _isOperated;
        }

        protected bool getState()
        {
            return this.isOperated;
        }
    }
}
