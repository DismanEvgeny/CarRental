﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;
using Entities;

namespace Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        DataBaseUtils utils = new DataBaseUtils();

        public string getID()
        {
            return utils.getsMaxID("Users");
        }


        public bool addToDB(string[] worker)
        { 
            return utils.insertInDB("Users", worker); ;
        }

        public string getAmountOfUsers()
        {
            return utils.getUsersAmount();
        }

        public string[,] getAllUsersFromDB(int workerCounter)
        {
            return utils.getAllUsersFromDB(workerCounter); 
        }

        public void deleteUserFromDB(string ID)
        {
            utils.deleteUserFromDB(ID);
        }

        public string getWorkerId(string login)
        {
            return utils.getWorkerIdFromDB(login);
        }
    }
}
