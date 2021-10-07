using APiEstudo.Data;
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
        private readonly DataContext _context;
        public ProdutosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ProdutosController>
        [HttpGet("produtos")]
        public ActionResult Get()
        {
            return Ok(_context.Produtos);
        }
    }
}