using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IDatabase db;
        public TestController(IDatabase db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var ticks = HttpContext.Items["ticks"];
            return Ok($"Dependencia: {db.Ticks} Middlware: {ticks}");

            //db.Create();
            //var result = db.GetProducts();
            //return Ok(result);
        }
    }
}