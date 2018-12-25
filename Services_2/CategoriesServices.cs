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

        public bool checkData(string ID, string name)
        {
            if (ID == null || name == null)
                return false;

            if (ID.Length > 30 || name.Length > 30)
                return false;

            return true;
        }

        public bool addCategoryToDB(Category category)
        {
            if (!checkData(category.getID(), category.getName()))
                return false;
            // WorkerRepository workerRepository = new WorkerRepository();
            string[] categoryString = new string[4];

            categoryString[0] = category.getID();
            categoryString[1] = category.getName();
            categoryString[2] = category.getTarif().ToString();
            categoryString[3] = category.getFine().ToString();


            return categoriesRepository.addToDB(categoryString);
        }
    }
}
