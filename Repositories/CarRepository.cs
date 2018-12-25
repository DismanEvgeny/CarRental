using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;

namespace Repositories
{
    class CarRepository : ICarRepository
    {
        DataBaseUtils dataBaseUtils = new DataBaseUtils();

        public void deleteCarFromDB(string ID)
        {

        }

        public string[,] getAllCarsFromDB(uint carCounter)
        {
            return null;
        }

        public bool insertCarInDB(string[] carString)
        {
            return dataBaseUtils.insertInDB("Cars", carString); ;
        }
    }
}
