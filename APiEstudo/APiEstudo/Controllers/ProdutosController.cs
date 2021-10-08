using APiEstudo.Data;
using APiEstudo.Models;
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

        // GET: api/produtos
        [HttpGet("produtos")]
        public ActionResult Get()
        {
            return Ok(_context.Produtos);
        }

        // GET/ID: api/produtos/id
        [HttpGet("produtos/{id}")]
        public ActionResult GetId(int id)
        {
            var message = new List<object>() { "Object not found " };
            var product = _context.Produtos.FirstOrDefault(product => product.Id == id);
            if (product == null) return BadRequest(message);
            return Ok(product);
        }

        // POST: api/produtos/post
        [HttpPost("produtos/new")]
        public ActionResult CreateProduct([FromBody] Produtos product)
        {
            try
            {
                _context.Produtos.Add(product);
                _context.SaveChanges();
                return Ok("Product insert Sucess!");

            } catch
            {
                return BadRequest("Houve um erro");
            };
           
        }

        // PUT: api/produtos/put
        [HttpPut("produtos/ed")]
        public ActionResult Edit()
        {
            return Ok();
        }
    }
}