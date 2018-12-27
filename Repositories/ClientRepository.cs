using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;
using Entities;

namespace Repositories
{
    public class ClientRepository : IClientRepository
    {
        DataBaseUtils dataBaseUtils;

        public ClientRepository()
        {
            dataBaseUtils = new DataBaseUtils();
        }

        public bool addClientToDB(string[] clientString)
        {
            return dataBaseUtils.insertInDB("Clients",clientString);
        }

        public int getMaxId()
        {
            return int.Parse(dataBaseUtils.getsMaxID("Clients"));
        }

        public List<string[]> getAllClients()
        {
            return dataBaseUtils.getClientsFromDB();
        }

        public string[] getClient(string clientId)
        {
            return dataBaseUtils.getClientFromDB(clientId);
        }
    }
}
