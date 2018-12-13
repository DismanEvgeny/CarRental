using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repositories
{
    public class DataBaseUtils
    {
        private static string path = (System.Environment.CurrentDirectory).Remove(path.IndexOf("\\bin") ,10) + "\\DB.mdf"; //путь к базе данных



    }
}
