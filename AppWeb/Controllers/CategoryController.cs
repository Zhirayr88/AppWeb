using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prj.Models;
using prj.Services.Interface;

namespace AppWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route ("Get")]
        public IActionResult Get(int id) 
        { 
            if (id == 0)
            {
                return BadRequest();
            }
            var category = _categoryService.Get(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet]
        [Route("All")]
        public IActionResult GetAll() 
        {
            var categories = _categoryService.GetAll(); 
            if(categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult Create (Category category)
        {

            bool isAdded = _categoryService.Add(category);
            if (!isAdded) 
            {
                return BadRequest();
            }
            return Ok();

        }

        [HttpPut]

        public IActionResult Update (Category category)
        {
            var categoryIsUpdated = _categoryService.Update(category);
            if (!categoryIsUpdated)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var categoryIsDeleted = _categoryService.Delete(id);

            if (!categoryIsDeleted)
                return NotFound();
            return Ok();
        }
    }
}
