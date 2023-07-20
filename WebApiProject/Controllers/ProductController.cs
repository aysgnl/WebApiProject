using Microsoft.AspNetCore.Mvc;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Field(s)
        private readonly ILogger<ProductController> _logger;
        #endregion

        #region Constructor(s)
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Method(s)
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, Name = "Test" }
            };

            _logger.LogInformation("GetAllProducts action has been called.");
            return Ok(products);
        }
        #endregion
    }
}
