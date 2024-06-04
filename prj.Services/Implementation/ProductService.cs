using prj.Data.Interface;
using prj.Models;
using prj.Models.Dto;
using prj.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Services.Implementation
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _productrepository;
        private readonly ICategoryRepository _categoryrepository;

        public ProductService(IProductRepository productrepository, ICategoryRepository categoryRepository)
        {
            _productrepository = productrepository;
            _categoryrepository = categoryRepository;
        }
        public void Add(Product product) => _productrepository.Add(product);
     

        public ProductDto Get(int id) 
        {
            var product = _productrepository.Get(id);
            var productDto = new ProductDto
            {
                CategoryName = product.Category.Name,
                Name = product.Name,
                Price = product.Price,
                ProductId = product.Id,

            };

            return productDto;
            
        }
        public bool Delete(int id)
        {
            return _productrepository.Delete(id);
        }


        public List<Product> GetAll()
        {
            return _productrepository.GetAll();
        }

        public bool Update( Product product)
        {
            return (_productrepository.Update(product));
        }



    }
}
