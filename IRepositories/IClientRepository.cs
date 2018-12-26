using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IRepositories
{
    public interface IClientRepository
    {
        bool addClientToDB(string[] clientString);
        int getMaxId();
        List<string[]> getAllClients();
    }
}
