using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OficinaAPI.Data;
using OficinaAPI.Models;

namespace OficinaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly DataContext _context;

        public ServicoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetServicos()
        {
            var servicos = _context.Servicos
                .Include(s => s.Cliente)
                .ToList();
            return Ok(servicos);
        }

        [HttpPost]
        public IActionResult AddServico(Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetServicos), new { id = servico.Id }, servico);
        }
    }
}
