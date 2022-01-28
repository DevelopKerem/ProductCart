using Business.Services;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("getProducts")]
        public List<Product> getProducts()
        {
            return _productService.getProducts();
        }
        [HttpGet]
        [Route("get")]
        public async Task <Product> Get(int id)
        {
            return await _productService.GetProduct(id);
        }
        [HttpPost]
        [Route("add")]
        public void Add(Product product)
        {
            _productService.Add(product);
        }
        [HttpPut]
        [Route("update")]
        public void UpdateProduct(int id, Product product)
        {
            product.Id = id;
            _productService.Update(product);
        }
        [HttpDelete]
        [Route("delete")]
        public void DeleteProduct(Product id)
        {
            _productService.Delete(id);
        }
    }
}
