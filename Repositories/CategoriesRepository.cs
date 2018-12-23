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
        public List<string[]> getCategories()
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            return dataBaseUtils.getCategoriesFromDB();
        }
    }
}
