using System.Formats.Asn1;
using LojaTech.Models;
using LojaTech.Repository;
using LojaTech.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IRepository<Funcionario> _funcionarioRepo;
        private readonly IFuncionarioRepository _enderecoRepo;

        public FuncionariosController(IRepository<Funcionario> funcionario, IFuncionarioRepository enderecoRepo)
        {
            _funcionarioRepo = funcionario;
            _enderecoRepo = enderecoRepo;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Funcionario>> Get()
        {
             return await _funcionarioRepo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Funcionario>> GetId(int id)
        {
            var funcionario = await _enderecoRepo.GetById(id);
            if (funcionario == null)
            {
                return BadRequest("Funcionario não localizado");
            }
            return Ok(funcionario);
        }

        [HttpPost]
        public async Task<ActionResult<Funcionario>> Post([FromBody] Funcionario funcionario)
        {
            var funcionarioCadastrado = await _funcionarioRepo.AddAsync(funcionario);
            if (funcionarioCadastrado == null)
            {
                return BadRequest("Erro ao cadastrar funcionario");
            }
            return Ok(funcionarioCadastrado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Funcionario>> Put(Funcionario funcionario, int id)
        {
            if (id != funcionario.Id)
            {
                return BadRequest("Funcionario não localizado");   
            }
            var atualiza = await _funcionarioRepo.UpdateAsync(funcionario);
            if (atualiza == null)
            {
                return BadRequest("Erro ao atualizar funcionario");
            }
            return Ok(funcionario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Funcionario>> Delete(int id)
        {
            var localizaFuncionario = await _enderecoRepo.GetById(id);
            if (localizaFuncionario == null)
            {
                return BadRequest("Funcionario não localizado");
            }
            var deletado = await _enderecoRepo.DeleteAsync(localizaFuncionario);
            return Ok(deletado);
        }
    }
}