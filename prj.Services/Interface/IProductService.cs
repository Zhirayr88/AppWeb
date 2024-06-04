using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj.Models;
using prj.Models.Dto;

namespace prj.Services.Interface
{
    public interface IProductService
    {
        void Add(Product product);
        ProductDto Get(int id);

        public List<Product> GetAll();

        public bool Delete(int id);

        public bool Update(Product product);

    }
}
