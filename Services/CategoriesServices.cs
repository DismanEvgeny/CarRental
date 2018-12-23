using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using IServices;
using IRepositories;
using Repositories;

namespace Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private ICategoriesRepository categoriesRepository;

        public CategoriesServices()
        {
            categoriesRepository = new CategoriesRepository();
        }

        public List<Category> getCategories() // извлечение из БД всех категорий
        {
            List<Category> categories = new List<Category>();
            List<string[]> categoryStrings = categoriesRepository.getCategories();


            foreach (string[] str in categoryStrings)
            {
                categories.Add(new Category(str[0], str[1], float.Parse(str[2]), float.Parse(str[3])));
                Console.WriteLine(str[1]);
            }
            return categories;
        }
    }
}
