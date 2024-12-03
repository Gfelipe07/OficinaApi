using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OficinaAPI.Data;
using OficinaAPI.Models;

namespace OficinaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            return Ok(_context.Clientes.ToList());
        }

        [HttpPost]
        public IActionResult AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetClientes), new { id = cliente.Id }, cliente);
        }
    }
}
