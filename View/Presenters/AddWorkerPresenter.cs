using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenrers.Views;
using IServices;
using Entities;

namespace Presenrers.Presenters
{
    class WorkerPresenter
    {
        private Worker worker;

        public WorkerPresenter() { }

        /*public WorkerPresenter(string _name, string _surname, string _login, string _password)
         {
             //worker = new Worker(_name, _surname, _login, _password);
         }*/

        public bool addWorker(string _name, string _surname, string _login, string _password)
        {
            bool check = false;

            if (string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_surname) || string.IsNullOrEmpty(_login) ||
                    string.IsNullOrEmpty(_password)) { return check; }
            else
            {
                worker = new Worker(_name, _surname, _login, _password);
                check = true;
                return check;
            }
        }

    }
}
