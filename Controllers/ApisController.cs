using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnetRestfulAPI.Models;

namespace dotnetRestfulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApisController: ControllerBase
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

        [HttpPost]
        public ActionResult<SimpleModel> CreateSimpleObject(SimpleModel model) {
            _context.SimpleModel.Add(model);
            _context.SaveChanges();

            return CreatedAtAction("GetSimpleObject", new SimpleModel { Id = model.Id }, model);
        }

    }
}