using MentalHealth_.Data;
using MentalHealth_.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentalHealth_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AvaliacaoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Salvar([FromBody] Avaliacao avaliacao)
        {
            avaliacao.Data = DateTime.UtcNow;
            _context.Avaliacoes.Add(avaliacao);
            await _context.SaveChangesAsync();
            return Ok(new { mensagem = "Avaliação salva com sucesso!" });
        }
    }
}