using LojaTech.Models;
using LojaTech.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojaTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        //private readonly IRepository<Cliente> _cliente;
        private readonly IClienteRepository _clienteRepo;

        public ClientesController(IClienteRepository clienteRepo)
        {
            _clienteRepo = clienteRepo;
        }

        #region Region GetId
        //public ClientesController(IRepository<Cliente> cliente, IClienteRepository clienteRepo)
        //{
        //    _cliente = cliente;
        //    _clienteRepo = clienteRepo;
        //}
        #endregion
        
        [HttpGet]
        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _clienteRepo.GetAllAsync();
        }

        #region Predicate
        //[HttpGet("buscar/{id}")]
        //public async Task<ActionResult<Cliente>> GetById(int id)
        //{
        //    var cliente = await _clienteRepo.GetIdAsync(c => c.Id == id);
        //    if (cliente == null)
        //    {
        //        return NotFound("Cliente não encontrado");
        //    }
        //    return Ok(cliente);
        //}
        #endregion

        [HttpGet("{id}")]
        public async Task<ActionResult> GetId(int id)
        {
            var cliente = await _clienteRepo.GetId(id);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return Ok(cliente);
        }

        [HttpPost] 
        public async Task<ActionResult<Cliente>> Post(Cliente cliente)
        {
            var clienteCadastrado = await _clienteRepo.AddAsync(cliente);
            if (clienteCadastrado == null)
            {
                return BadRequest("Erro ao cadastrar cliente");
            }
            return Ok(clienteCadastrado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Cliente>> Put(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest("ID do cliente não corresponde ao ID informado na URL");
            }
            var atualiza = await _clienteRepo.UpdateAsync(cliente);
            if (atualiza == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return Ok(atualiza);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Cliente>> Delete(int id)
        {
            var cliente = await _clienteRepo.GetId(id);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            var clienteDeletado = await _clienteRepo.DeleteAsync(cliente);
            return Ok(clienteDeletado);
        }
    }
}