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
        CategoriesServices categoryService;

        public CategoriesPresenter()
        {
            categoryService = new CategoriesServices();
        }

        public static List<Category> getCategories()
        {
            return new CategoriesServices().getCategories();
        }

        public bool addCategory(string _name, string _tarif, string _fine, string _ID)
        {
            bool check = false;
            float n;

            if (!(string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_tarif.ToString()) ||
                    string.IsNullOrEmpty(_tarif.ToString()) || string.IsNullOrEmpty(_ID)))
            {
                if (!float.TryParse(_tarif, out n) || !float.TryParse(_fine, out n))
                    return check;
                Category category = new Category(_ID, _name, float.Parse(_tarif), float.Parse(_fine));
                CategoriesServices service = new CategoriesServices();

                check = service.addCategoryToDB(category);
            }
            return check;
        }

    }
}
