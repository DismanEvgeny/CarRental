using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IServices;
using Repositories;

namespace Services
{
    public class ContractsServices : IContractsServices
    {
        ContractRepository contractRepository;

        public ContractsServices()
        {
            contractRepository = new ContractRepository();
        }

        public Contract addContract(string[] contractStrings)
        {
            Contract contract = new Contract(int.Parse(contractStrings[0]), int.Parse(contractStrings[1]), int.Parse(contractStrings[2]),
                int.Parse(contractStrings[3]), DateTime.Parse(contractStrings[4]), DateTime.Parse(contractStrings[5]),
                DateTime.Parse(contractStrings[6]), float.Parse(contractStrings[7]), "");

            if (!contractRepository.addContractToDB(contractStrings))
            {
                return null;
            }
            return contract;
        }

        public string getMaxId()
        {
            return contractRepository.getMaxId();
        }

        public List<Contract> getActiveContracts()
        {
            List<Contract> contracts = new List<Contract>();
            List<string[]> contractStrings = contractRepository.getActiveContracts();
            foreach (string[] str in contractStrings)
            {
                contracts.Add(new Contract(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2]), int.Parse(str[3]), 
                    DateTime.Parse(str[4]), DateTime.Parse(str[5]), DateTime.Parse(str[6]), float.Parse(str[7]), "" ));
            }
            return contracts;
        }

        public void updateContract(Contract contract)
        {
           // string[] contractStrings 
            contractRepository.updateContract(contract);
        }
    }
}
