using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IRepositories
{
    public interface ICarRepository
    {
        bool insertCarInDB(string[] carString, Image img);
        List<string[]> getAllCarsFromDB(uint carCounter);
        void deleteCarFromDB(string ID);

    }
}
