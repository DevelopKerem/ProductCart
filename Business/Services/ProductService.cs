using Entities.Concrete;
using Entities.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductService:IProductService
    {
        public EfDbContext _dbContext;

        public ProductService(EfDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Product product)
        {
            _dbContext.products.Add(product);
            _dbContext.SaveChanges();
        }

        public void Delete(Product id)
        {
            _dbContext.Remove(id);
            _dbContext.SaveChanges();
        }

        public async Task <Product> GetProduct(int id)
        {
            var data = await _dbContext.products.FirstOrDefaultAsync(p => p.Id == id);
            return data;

        }

        public List<Product> getProducts()
        {
            return _dbContext.products.ToList();

        }

        public void Update(Product product)
        {
            _dbContext.products.Update(product);
            _dbContext.SaveChanges();
        }

        public async Task<Product> UpdateImage(int id, string imagePath)
        {
                  var imageDetails = await _dbContext.products.FindAsync(id);
                  imageDetails.Image = imagePath;
                  var updateImage = _dbContext.products.Update(imageDetails);
                  await _dbContext.SaveChangesAsync();
                  var returnData = updateImage.Entity;
            return returnData;
        }
    }
}
