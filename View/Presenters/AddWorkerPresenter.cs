using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenrers.Views;
using IServices;
using Entities;
using Services;

namespace Presenrers.Presenters
{
    class WorkerPresenter
    {
        public WorkerPresenter() { }


        public static bool addWorker(string _name, string _surname, string _login, string _password, bool _isAdmin)
        {
            bool check = false;

            if (!(string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_surname) || string.IsNullOrEmpty(_login) ||
                    string.IsNullOrEmpty(_password)))
            {
                Worker worker = new Worker(_name, _surname, _login, _password, _isAdmin);
                //check = true;
                WorkerService service = new WorkerService();
                check = service.addWorkerToDB(worker);

                //тут будет работа с репозиторием и сервисами
            }
            return check;
        }

    }
}
