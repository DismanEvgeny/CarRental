using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IRepositories;
using IServices;
using Repositories;

namespace Services
{
    public class ClientService : IClientService
    {
        IClientRepository clientRepository;

        public ClientService()
        {
            clientRepository = new ClientRepository();
        }

        public Client addClient(string[] clientStrings)
        {
            int id = clientRepository.getMaxId() + 1;
            Client client = new Client(id, clientStrings[1], clientStrings[2], (clientStrings[3] == "True" || clientStrings[3] == "1"), DateTime.Parse(clientStrings[4]), clientStrings[5]);
            clientStrings[0] = id.ToString();

            if (clientRepository.addClientToDB(clientStrings))
            {
                return client;  
            }
            return null;
        }

        public Client getClient(string clientId)
        {
            string[] clientStrings = clientRepository.getClient(clientId);
            if (clientStrings == null)
            {
                return null;
            }
            return new Client(int.Parse(clientStrings[0]), clientStrings[1], clientStrings[2], 
                (clientStrings[3] == "True" || clientStrings[3] == "1"), DateTime.Parse(clientStrings[4]), (clientStrings[5] == "True" || clientStrings[5] == "1"),
                clientStrings[6]); 
        }

        public List<Client> getClients()
        {
            List<Client> clients = new List<Client>();
            List<string[]> strings = clientRepository.getAllClients();
            foreach(string[] str in strings)
            {
                clients.Add(new Client(int.Parse(str[0]), str[1], str[2], (str[3] == "True" || str[3] == "1"), DateTime.Parse(str[4]), (str[5] == "True" || str[5] == "1"), str[6]));
            }
            return clients;
        }
    }
}
