using prj.Models;
using prj.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Data.Interface
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product Get(int id);
        public List<Product> GetAll();

        public bool Delete(int id);

        public bool Update(Product product);

    }
}
