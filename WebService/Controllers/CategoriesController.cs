using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private IDataService dataService;

        public CategoriesController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        // GET: api/categories
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(dataService.GetCategories());
        }

        // GET api/categories/5
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            Category category = dataService.GetCategory(id);

            if (category != null)
            {
                return Ok(category);
            }
            return NotFound();
        }

        // POST api/categories
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            if (category != null)
            {
                category = dataService.CreateCategory(category.Name, category.Description);
                return Created($"/api/categoroes/{category.Id}", category);
            }
            return BadRequest();
            
        }

        // PUT api/categories/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            if(id != null)
            {
                bool result = dataService.UpdateCategory(id, category.Name, category.Description);
                if (result == true)
                {
                    return Ok();
                }
            }
            return NotFound();
        }

        // DELETE api/categories/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = dataService.DeleteCategory(id);
            if (result == true)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
