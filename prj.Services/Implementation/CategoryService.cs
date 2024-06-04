using prj.Data.Interface;
using prj.Models;
using prj.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Services.Implementation
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public bool Add(Category category) => _categoryRepository.Add(category);
        

        public bool Delete(int id)
        {
            return _categoryRepository.Delete(id);
        }

        public Category Get(int id)
        {
            return _categoryRepository.Get(id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public bool Update(Category category)
        {
            return (_categoryRepository.Update(category));
        }
    }
}
