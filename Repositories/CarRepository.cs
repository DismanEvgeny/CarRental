﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;
using System.Drawing;

namespace Repositories
{
    public class CarRepository : ICarRepository
    {
        DataBaseUtils dataBaseUtils = new DataBaseUtils();
         

        public void deleteCarFromDB(string ID)
        {
            dataBaseUtils.deleteCar(ID);
        }

        public List<string[]> getAllCarsFromDB(uint carCounter)
        {
            return dataBaseUtils.getCarsFromDB();
        }

        public List<string[]> getCarsFromDB(string categoryId)
        {
            return dataBaseUtils.getCarsFromDB(categoryId);
        }

        public string[] getCarFromDB(string Id)
        {
            return dataBaseUtils.getCarFromDB(Id);
        } 

        public string getID()
        {
            return dataBaseUtils.getsMaxID("Cars");
        }

        public int insertCarInDB(string[] carString, Image img)
        {
            int maxId = int.Parse(getID()) + 1;
            string[] carString2 = new string[]{ maxId.ToString(), carString[0], carString[1], carString[2], carString[3], carString[4], carString[5], carString[6] };
            if (dataBaseUtils.insertInDB("Cars", carString2)) {
                return maxId;
            }
            else
            {
                return -1;
            }
        }

        public void setOccupied(string carId)
        {
            dataBaseUtils.setOccupied(carId);
        }

        public uint carsInUse()
        {
            return dataBaseUtils.carsInUse();
        }

        public List<string[]> getCarsOccupied(bool isOccupied)
        {
            return dataBaseUtils.getCarsOccupiedFromDB(isOccupied);
        }
    }
}
