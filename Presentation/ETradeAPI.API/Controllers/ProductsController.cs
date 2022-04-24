using ETradeAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETradeAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1" ,Price = 100, CreatedDate = DateTime.UtcNow, Stock = 104},
                new() { Id = Guid.NewGuid(), Name = "Product 2" ,Price = 200, CreatedDate = DateTime.UtcNow, Stock = 13},
                new() { Id = Guid.NewGuid(), Name = "Product 3" ,Price = 300, CreatedDate = DateTime.UtcNow, Stock = 123},
            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
