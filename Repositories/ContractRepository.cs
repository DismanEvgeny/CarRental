using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class ContractRepository
    {
        DataBaseUtils dataBaseUtils;

        public ContractRepository()
        {
            dataBaseUtils = new DataBaseUtils();
        }

        public bool addContractToDB(string[] contractStrings)
        {
            return dataBaseUtils.insertInDB("Contracts", contractStrings);
        }

        public string getMaxId()
        {
            return dataBaseUtils.getsMaxID("Contracts");
        }

        public List<string[]> getActiveContracts()
        {
            return dataBaseUtils.getActiveContracts();
        }

        public void updateContract(Contract contract)
        {
            dataBaseUtils.updateContract(contract);
        }
    }
}
