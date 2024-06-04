using prj.Data.Context;
using prj.Data.Interface;
using prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace prj.Data.Implementation
{
    internal class CategoryRepository : ICategoryRepository
    
    {
        private readonly prjDbContext _prjDbContext;
        public CategoryRepository(prjDbContext prjDbContext)
        {
            _prjDbContext = prjDbContext;
        }


        private static readonly List<Category> _categories = new List<Category>();

        public bool Add(Category category)
        {
            if (category == null || category.Id < 0 || _categories.Any(c => c.Id == category.Id))
            {
                return false;
            }
            
            //_categories.Add(category);
            _prjDbContext.Categories.Add(category);
            _prjDbContext.SaveChanges();
            return true; ;
        }

        public bool Delete(int id)
        {
            Category category = _categories.FirstOrDefault(x => x.Id == id);
            //return _categories.Remove(category);
             _prjDbContext.Categories.Remove(category);
            _prjDbContext.SaveChanges();
            return true;
        }

        public Models.Category Get(int id) => _prjDbContext.Categories.FirstOrDefault(x => x.Id == id);

        public List<Category> GetAll()
        {
            //return _categories;
            return _prjDbContext.Categories.ToList();
        }

        public bool Update(Category category)
        {

            _prjDbContext.Categories.Update(category);
            _prjDbContext.SaveChanges();

            return true;
        }
    }

}
