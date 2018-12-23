using System;
using System.Collections.Generic;
using System.Text;
using IServices;
using Entities;
using IRepositories;
using Repositories;

namespace Services
{
    public class AddWorkerService : IAddWorkerService
    {
        private IAddWorkerRepository addWorkerRepository;

        public AddWorkerService()
        {
            addWorkerRepository = new AddWorkerRepository();
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
            bool check = false;
            if (!checkData(worker.login, worker.password))
                return check;

            AddWorkerRepository addWorkerRepository = new AddWorkerRepository();
            check = addWorkerRepository.addToDB(worker);

            return check;
        }
    }
}
