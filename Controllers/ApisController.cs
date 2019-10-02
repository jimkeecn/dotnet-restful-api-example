using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace dotnetRestfulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApisController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString() {
            return new string[]
            {
                "This", "is", "first", "response"
            };
        }
    }
}