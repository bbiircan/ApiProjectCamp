﻿using ApiProjectCamp.WebApi.Context;
using ApiProjectCamp.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectCamp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiContext _context;

        public CategoriesController(ApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);  
            _context.SaveChanges();
            return Ok("The addition operation was successful.");
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _context.Categories.ToList();
            return Ok(values);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id) 
        {
            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("The category has been successfully deleted.");
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _context.Categories.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("The category has been successfully updated.");
        }
    }
}
