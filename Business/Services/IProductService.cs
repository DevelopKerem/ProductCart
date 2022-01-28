using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IProductService
    {
        List<Product> getProducts();
        public void Add(Product product);
        public Task <Product> GetProduct(int id);
        public void Update(Product product);
        public void Delete(Product id);
        public Task<Product> UpdateImage(int id , string imagePath);
    }
}
