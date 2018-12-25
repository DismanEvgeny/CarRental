using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IServices
{
    public interface ICarsServices
    {
        List<Car> getCars();
        bool addCarToDB(string[] carStrings);
    }
}
