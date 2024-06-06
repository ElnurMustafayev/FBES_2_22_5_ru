using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinimalApiApp.Models;

namespace MinimalApiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Method() {
            return "Hello World!";
        }

        [HttpGet]
        [ActionName("Product")]
        [Route("/api/[action]/{id}")]
        public Product GetProduct(Guid id, string? name) {
            return new Product {
                Id = Guid.NewGuid(),
                Name = name,
                Price = null,
                Status = ProductStatuses.standart,
            };
        }

        [HttpPost]
        public IActionResult Create(Product product) {
            if(true) {
                return base.StatusCode(500);
            }
        }
    }
}