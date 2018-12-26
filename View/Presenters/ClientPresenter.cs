using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;
using Entities;
using Services;

namespace Presenrers.Presenters
{
    public class ClientPresenter
    {
        private ClientService clientService;
        
        public ClientPresenter()
        {
            clientService = new ClientService();
        }

        public Client addClient(string[] clientStrings)
        {
            return clientService.addClient(clientStrings);
        }

        public List<Client> getClients()
        {
            return clientService.getClients();
        }

    }
}
