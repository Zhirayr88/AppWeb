using prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Data.Interface
{
    public interface ICategoryRepository
    {
        public bool Add(Category category);

        public Category Get(int id);

        public List<Category> GetAll();

        public bool Delete(int id);

        public bool Update(Category category);
     
    }
}
