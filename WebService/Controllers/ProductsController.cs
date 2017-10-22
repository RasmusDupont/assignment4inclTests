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
        DataService dataservice;

        public ProductsController(DataService dataservice)
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
        [HttpGet("{name}")]
        public IActionResult Name(string name)
        {
            List<ProductSimpleDTO> result = new List<ProductSimpleDTO>();
            List<Product> products = dataservice.GetProductByName(name);
            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    result.Add(new ProductSimpleDTO(
                            products[i].Name,
                            products[i].Category.Name
                        ));
                }
                return Ok(result);
            }
            return NotFound();
        }

        //8. GET: api/products/categories
        [HttpGet("{id}")]
        public IActionResult Categories(int id)
        {
            List<ProductDTO> result = new List<ProductDTO>();
            List<Product> products = dataservice.GetProductByCategory(id);
            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    result.Add(new ProductDTO(
                            products[i].Name,
                            products[i].UnitPrice,
                            products[i].Category.Name
                        ));
                }
                return Ok(result);
            }
            return NotFound();
        }
    }
}
