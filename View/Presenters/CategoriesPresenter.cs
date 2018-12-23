using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace Presenrers.Presenters
{
    public class CategoriesPresenter
    {
        public static List<Category> getCategories()
        {
            return new CategoriesServices().getCategories();
        }

    }
}
