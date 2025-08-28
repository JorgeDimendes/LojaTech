using LojaTech.Models;
using LojaTech.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojaTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepo;

        public ProdutosController(IProdutoRepository produtoRepo)
        {
            _produtoRepo = produtoRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _produtoRepo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var pesquisaProduto = await _produtoRepo.getId(id);
            if (pesquisaProduto == null) return NotFound($"Produto do id {id} não foi localizado");
            return Ok(pesquisaProduto);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Post([FromBody] Produto produto)
        {
            var cadastraProduto = await _produtoRepo.AddAsync(produto);
            if (cadastraProduto == null) return BadRequest("Erro ao cadastrar produto");
            return Ok(cadastraProduto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Produto>> Put(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id) return BadRequest($"Id do produto incorreto");
            var atualizaProduto = await _produtoRepo.UpdateAsync(produto);
            if(atualizaProduto == null) return BadRequest("Erro ao atualizar produto");
            return Ok(atualizaProduto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> Delete(int id)
        {
            var verificaProduto = await _produtoRepo.getId(id);
            if (verificaProduto == null) return BadRequest($"Produto com id {id} não existe, informe id valido");
            var deletaProduto = _produtoRepo.DeleteAsync(verificaProduto);
            return Ok(deletaProduto);
        }
    }
}