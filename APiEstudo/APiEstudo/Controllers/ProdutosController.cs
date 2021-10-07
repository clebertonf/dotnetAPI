using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APiEstudo.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProdutosController : ControllerBase
    {
        // GET: api/<ProdutosController>
        [HttpGet("produtos")]
        public ActionResult Get()
        {
            return Ok("Ola mundo");
        }
    }
}