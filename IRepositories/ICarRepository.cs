using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface ICarRepository
    {
        bool insertCarInDB(string[] carString);
        List<string[]> getAllCarsFromDB(uint carCounter);
        void deleteCarFromDB(string ID);

    }
}
