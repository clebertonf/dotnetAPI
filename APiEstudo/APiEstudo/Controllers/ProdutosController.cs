using APiEstudo.Data;
using APiEstudo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public ActionResult GetId([FromRoute] int id)
        {

            var product = _context.Produtos.FirstOrDefault(product => product.Id == id);
            if (product == null) return BadRequest("Product not found ");
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
                return BadRequest("Houve um erro, Produto não cadastrado");
            };
           
        }

        // PUT: api/produto/edit
        [HttpPut("produtos/{id}")]
        public ActionResult EditProduct(int id, [FromBody] Produtos produto)
        {
          try
            {
                var product = _context.Produtos.AsNoTracking().FirstOrDefault(product => product.Id == id);
                if (product == null) return BadRequest("Product not found ");

                _context.Update(produto);
                _context.SaveChanges();
                return Ok(produto);
            }
            catch
            {
                return BadRequest("Houve um erro, produto não editado!");
            }
        }

        // DELETE: api/produto/delete
        [HttpDelete("produtos/{id}")]
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                var product = _context.Produtos.AsNoTracking().FirstOrDefault(product => product.Id == id);
                if (product == null) return BadRequest("Product not found ");

                _context.Remove(product);
                _context.SaveChanges();
                return Ok("Produto removido com Sucesso");
            }
            catch
            {
                return BadRequest("Houve um erro, produto não Deletado!");
            }

        }
    }
}