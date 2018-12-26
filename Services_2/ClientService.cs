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
            int id = clientRepository.getMaxId();
            Client client = new Client(id, clientStrings[0], clientStrings[1], (clientStrings[2] == "True" || clientStrings[2] == "1"), DateTime.Parse(clientStrings[3]));
            string[] clientStrings2 = new string[] { id.ToString(), clientStrings[0], clientStrings[1], clientStrings[2], clientStrings[3] };
            if (clientRepository.addClientToDB(clientStrings))
            {

                return client;
                
            }
            return null;
        }

        public List<Client> getClients()
        {
            List<Client> clients = new List<Client>();
            List<string[]> strings = clientRepository.getAllClients();
            foreach(string[] str in strings)
            {
                clients.Add(new Client(int.Parse(str[0]), str[1], str[2], (str[3] == "True" || str[3] == "1"), DateTime.Parse(str[4])));
            }
            return clients;
        }
    }
}
