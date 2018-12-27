using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace Presenrers.Presenters
{
    public class ContractPresenter
    {
        ContractsServices contractsServices;

        public ContractPresenter()
        {
            contractsServices = new ContractsServices();
        }

        public Contract addContract(string[] contractStrings)
        {
            return contractsServices.addContract(contractStrings);
        }

        public int getMaxId()
        {
            return int.Parse(contractsServices.getMaxId());
        }

        public List<Contract> getActiveContracts()
        {
            return contractsServices.getActiveContracts();
        }

        public void updateContract(Contract contract)
        {
            contractsServices.updateContract( contract);
        }
    }
}
