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
        private CarsServices carsServices = new CarsServices();

        public List<Car> getCars()
        {
            return carsServices.getCars();
        }

        public bool addCar(string[] carStrings)
        {
            return carsServices.addCarToDB(carStrings);
        }

    }
}
