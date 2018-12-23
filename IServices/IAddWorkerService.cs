using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IServices
{
    public interface IAddWorkerService
    {
        bool addWorkerToDB(Worker newWorker);
        bool checkData(string login, string password);

    }
}
