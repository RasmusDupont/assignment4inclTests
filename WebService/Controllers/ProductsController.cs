using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4;
using WebService.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebService.Controllers
{

    [Route("api/products")]
    public class ProductsController : Controller
    {
        private IDataService dataservice;

        public ProductsController(IDataService dataservice)
        {
            this.dataservice = dataservice;
        }

        //6. GET api/products/5
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product product = dataservice.GetProduct(id);
            if (product != null)
            {
                ProductDTO dto = new ProductDTO(product.Name, product.UnitPrice, product.Category.Name);
                return Ok(dto);
            }
            return NotFound();
        }

        //7. GET: api/products/name
        [HttpGet("name/{name}")]
        public IActionResult Name(string name)
        {
            List<dynamic> result = new List<dynamic>();
            List<Product> products = dataservice.GetProductByName(name);
            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    result.Add(new
                    {
                        ProductName = products[i].Name,
                        Categeory = new
                        {
                            Name = products[i].Category.Name
                        }
                    });
                }
                return Ok(result);
            }
            return NotFound(result);
        }

        //8. GET: api/products/category
        [HttpGet("category/{id}")]
        public IActionResult Category(int id)
        {
            List<dynamic> result = new List<dynamic>();
            List<Product> products = dataservice.GetProductByCategory(id);
            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    result.Add(new
                    {
                        Name = products[i].Name,
                        UnitPrice = products[i].UnitPrice,
                        CategoryName = products[i].Category.Name
                    });
                }
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
