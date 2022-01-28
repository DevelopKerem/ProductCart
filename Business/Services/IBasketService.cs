using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IBasketService
    {
        List<Basket> getBaskets();
        public void Add(Product product);
        public void Update(Basket basket);
        public void Delete(Basket id);
        public Task<Basket> GetBasket(int id);
    }
}
