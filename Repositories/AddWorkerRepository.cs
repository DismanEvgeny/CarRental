using System;
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
            return utils.getMaxID();
        }


        public bool addToDB(string[] worker)
        { 
            return utils.insertInDB("Users", worker); ;
        }
    }
}
