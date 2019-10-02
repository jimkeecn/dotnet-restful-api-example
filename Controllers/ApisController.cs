using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnetRestfulAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetRestfulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApisController : ControllerBase
    {

        private readonly ApiContext _context;

        public ApisController(ApiContext context)
        {
            _context = context;
        }

        //Get:      api/apis
        [HttpGet]
        public ActionResult<IEnumerable<SimpleModel>> GetSimpleObject() {
            return _context.SimpleModel;
        }

        [HttpGet("{id}")]
        public ActionResult<SimpleModel> GetSimpleObject(int id)
        {
            var result = _context.SimpleModel.Find(id);
            if(result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpPost]
        public ActionResult<SimpleModel> CreateSimpleObject(SimpleModel model) {
            _context.SimpleModel.Add(model);
            _context.SaveChanges();

            return CreatedAtAction("GetSimpleObject", new SimpleModel { Id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateSimpleObject(int id, SimpleModel model)
        {
           if(id != model.Id)
            {
                return BadRequest("You have requested a bad request.");
            }

            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

    }
}