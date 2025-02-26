using ApiProjectCamp.WebApi.Context;
using ApiProjectCamp.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectCamp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefsController(ApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("The addition operation was successful.");
        }

        [HttpDelete] 
        public IActionResult DeleteChef(int id)
        {
            var value = _context.Chefs.Find(id);
            _context.Chefs.Remove(value);
            _context.SaveChanges();
            return Ok("The chef has been successfully deleted.");
        }

        [HttpPut]
        public IActionResult UpdateChef(Chef chef) 
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("The chef has been successfully updated.");
        }

        [HttpGet("GetChef")]
        public IActionResult GetChef(int id)
        {
            return Ok(_context.Chefs.Find(id));
        } 

        [HttpGet]
        public IActionResult ChefList()
        {
            return Ok(_context.Chefs.ToList());
        }

    }
}
