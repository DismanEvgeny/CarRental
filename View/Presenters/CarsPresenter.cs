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
        public List<Car> GetCars()
        {
            return carsServices.getCars();
        }

    }
}
