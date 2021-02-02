using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VS.Produto.Application;
using VS.Produto.CommandDTO;
using VS.Produto.ViewModel;

namespace VS.VendaSimples.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // GET: api/Produto
        [HttpGet]
        public IEnumerable<ProdutoViewModel> Get([FromServices] ProdutoService Service)
        {
            return Service.BuscarTodosProdutos();
        }

        // GET: api/Produto/5
        [HttpGet("{id}", Name = "Get")]
        public ProdutoViewModel Get([FromServices] ProdutoService Service, int id)
        {
            return Service.BuscarProdutoPorId(id);
        }

        // POST: api/Produto
        [HttpPost]
        public void Post([FromServices] ProdutoService Service, [FromBody] ProdutoInsertCommandDTO produto)
        {
            Service.InserirProduto(produto);
        }

        // PUT: api/Produto/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete([FromServices] ProdutoService Service, int id)
        {
            Service.DeletarProdutoPorId(id);
        }
    }
}
