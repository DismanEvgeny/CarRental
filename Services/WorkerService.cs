using System;
using System.Collections.Generic;
using System.Text;
using IServices;
using Entities;
using IRepositories;
using Repositories;

namespace Services
{
    public class WorkerService : IAddWorkerService
    {
        private WorkerRepository workerRepository;

        public WorkerService()
        {
            workerRepository = new WorkerRepository();
        }

        public bool checkData(string login, string password)
        {
            if (login == null || password == null)
                return false;

            if (login.Length > 30 || password.Length > 30)
                return false;

            return true;
        }

        public bool addWorkerToDB(Worker worker)
        {
            if (!checkData(worker.login, worker.password))
                return false;


           // WorkerRepository workerRepository = new WorkerRepository();
            string id = workerRepository.getID();
            worker.setID(int.Parse(id));
            string[] workerString = new string[6];

            workerString[0] = worker.ID.ToString();
            workerString[1] = worker.name.ToString();
            workerString[2] = worker.surname.ToString();
            workerString[3] = worker.login.ToString();
            workerString[4] = worker.password.ToString();
            workerString[5] = worker.isAdmin.ToString();

            return workerRepository.addToDB(workerString);
        }

        public string getUsersAmountFromDB()
        {
            return workerRepository.getAmountOfUsers();
        }

        public string[,] getAllUsers(int workerCounter)
        {
            return workerRepository.getAllUsersFromDB(workerCounter);
        }
    }
}
