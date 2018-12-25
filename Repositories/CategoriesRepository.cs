using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;

namespace Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        DataBaseUtils dataBaseUtils = new DataBaseUtils();

        public List<string[]> getCategories()
        {
            return dataBaseUtils.getCategoriesFromDB();
        }

        public bool addToDB(string[] category)
        {
            return dataBaseUtils.insertInDB("Categories", category); ;
        }
    }
}
