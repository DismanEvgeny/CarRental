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
        int insertCarInDB(string[] carString, Image img); //при удачной вставке возвращает ID добавленной машины, иначе -1
        List<string[]> getAllCarsFromDB(uint carCounter);
        void deleteCarFromDB(string ID);
        string getID();
        string[] getCarFromDB(string Id);

    }
}
