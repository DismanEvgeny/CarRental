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

        }

        public List<string[]> getAllCarsFromDB(uint carCounter)
        {
            return dataBaseUtils.getCarsFromDB();
        }

        public string getID()
        {
            return dataBaseUtils.getsMaxID("Cars");
        }

        public bool insertCarInDB(string[] carString, Image img)
        {
            int maxId = int.Parse(getID()) + 1;
            string[] carString2 = new string[]{ maxId.ToString(), carString[0], carString[1], carString[2], carString[3], carString[4], carString[5], carString[6] };

            return dataBaseUtils.insertInDB("Cars", carString2); ;
        }
    }
}
