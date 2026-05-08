using MentalHealth_.Data;
using MentalHealth_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentalHealth_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PesquisaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PesquisaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Salvar([FromBody] Pesquisa pesquisa)
        {
            pesquisa.Data = DateTime.UtcNow;
            _context.Pesquisas.Add(pesquisa);
            await _context.SaveChangesAsync();
            return Ok(new { mensagem = "Pesquisa salva com sucesso!" });
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> Buscar(int usuarioId)
        {
            var pesquisas = await _context.Pesquisas
                .Where(p => p.UsuarioId == usuarioId)
                .OrderByDescending(p => p.Data)
                .ToListAsync<Pesquisa>();

            return Ok(pesquisas);
        }
    }
}