﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IServices
{
    public interface IContractsServices
    {
        Contract addContract(string[] contractStrings);
        string getMaxId();
    }
}
