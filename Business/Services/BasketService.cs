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
    public class BasketService : IBasketService
    {
        public EfDbContext _dbContext;

        public BasketService(EfDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Product product)
        {
            Basket basket = new Basket()
            {
                Image = product.Image,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                CreatedBy = product.CreatedBy,
                CreatedTime = DateTime.Now,
                Description =product.Description
                
            };
            _dbContext.baskets.Add(basket);
            _dbContext.SaveChanges();
        }

        public void Delete(Basket id)
        {
            _dbContext.Remove(id);
            _dbContext.SaveChanges();
        }

        public List<Basket> getBaskets()
        {
            return _dbContext.baskets.ToList();
        }

        public void Update(Basket basket)
        {
            _dbContext.baskets.Update(basket);
            _dbContext.SaveChanges();
        }
        public async Task<Basket> GetBasket(int id)
        {
            var data = await _dbContext.baskets.FirstOrDefaultAsync(p => p.Id == id);
            var returnData = data;
            return returnData;

        }
    }
}
