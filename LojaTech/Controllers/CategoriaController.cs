using LojaTech.Models;
using LojaTech.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojaTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepo;

        public CategoriaController(ICategoriaRepository categoriaRepo)
        {
            _categoriaRepo = categoriaRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Categoria>> ObterTodos()
        {
            return await _categoriaRepo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> ObterPorId(int id)
        {
            var pesquia = await _categoriaRepo.ObterCategoriaPorId(id);
            if (pesquia == null) return NotFound($"Categoria do id {id} não encontrada");
            return Ok(pesquia);
        }

        [HttpPost]
        public async Task<ActionResult<Categoria>> Create(Categoria categoria)
        {
            var categoriacadastrada = await _categoriaRepo.AddAsync(categoria);
            if (categoriacadastrada == null) return BadRequest("Erro ao cadastrar categoria");
            return Ok(categoriacadastrada);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Categoria>> Update(int id, Categoria categoria)
        {
            if (id != categoria.Id) return BadRequest("Id da categoria deve ser a mesma informada");
            var categoriaAtualizado = await _categoriaRepo.UpdateAsync(categoria);
            if(categoriaAtualizado == null) return BadRequest("Erro ao atualizar categoria");
            return Ok(categoriaAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> Delete(int id)
        {
            var consutaId = await _categoriaRepo.ObterCategoriaPorId(id);
            if(consutaId == null) return BadRequest($"Erro ao localizar categoria do id {id}");
            var deleteCategoria = await _categoriaRepo.DeleteAsync(consutaId);
            if(deleteCategoria == null) return BadRequest("Erro ao deletar categoria");
            return Ok(deleteCategoria);
        }
    }
}