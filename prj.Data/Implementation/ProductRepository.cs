using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Outlook;
using prj.Data.Context;
using prj.Data.Interface;
using prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Data.Implementation
{
    internal class ProductRepository : IProductRepository
    {
        private readonly prjDbContext _prjDbContext;
        public ProductRepository(prjDbContext prjDbContext)
        {
                _prjDbContext = prjDbContext;
        }
        public void Add(Product product)
        {
            _prjDbContext.Add(product);
            _prjDbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            if (Get(id) == null)
            {
                throw new ArgumentOutOfRangeException("id not found");
            }

            else
            {
                Product productToDelete = _prjDbContext.Products.FirstOrDefault(x => x.Id == id);
                _prjDbContext.Products.Remove(productToDelete);
                _prjDbContext.SaveChanges();
                return true;

            }
        }

        public Product Get(int id) => _prjDbContext.Products.Include(x=>x.Category).FirstOrDefault(x => x.Id == id);

        public List<Product> GetAll()
        {
         return  _prjDbContext.Products.ToList<Product>();

        }

        public bool Update(Product product)
        {
            _prjDbContext.Update(product);
            _prjDbContext.SaveChanges();
            return true;
        }
    }
}
