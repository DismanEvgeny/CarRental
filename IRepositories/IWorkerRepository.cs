using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IRepositories
{
    public interface IWorkerRepository
    {
        bool addToDB(string[] worker);
        string getID();
        string getAmountOfUsers();
        string[,] getAllUsersFromDB(int workerCounter);
        void deleteUserFromDB(string ID);
        string getWorkerId(string login);
    }
}
