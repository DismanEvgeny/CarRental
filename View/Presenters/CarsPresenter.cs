using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace Presenrers.Presenters
{
    public class CarsPresenter
    {
        private CarsServices carsServices;

        public CarsPresenter()
        {
            carsServices = new CarsServices();
        }

        public List<Car> getCars()
        {
            return carsServices.getCars();
        }

        public List<Car> getCars(string categoryId)
        {
            return carsServices.getCars(categoryId);
        }

        public int addCar(string[] carStrings)
        {
            return carsServices.addCarToDB(carStrings);
        }

        public Car getCar(string Id)
        {
            return carsServices.getCar(Id);
        }

        public List<Car> getCarsOccupied(bool isOccupied)
        {
            return carsServices.getCarsOccupied(isOccupied);

        }

        public void deleteCar(string carId)
        {
            carsServices.deleteCar(carId);
        }

        public void setOccupied(string carId)
        {
            carsServices.setOccupied(carId);
        }

        public uint carsInUse()
        {
            return carsServices.carsInUse();
        }

    }
}
