﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;
using Entities;

namespace Repositories
{
    public class AddWorkerRepository : IAddWorkerRepository
    {
        public bool addToDB(Worker worker)
        {
            return true;
        }
    }
}