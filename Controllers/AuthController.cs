using MentalHealth_.Data;
using MentalHealth_.DTOs;
using MentalHealth_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentalHealth_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Cpf == dto.Cpf && u.Senha == dto.Senha);

            if (usuario == null)
                return Unauthorized(new { mensagem = "CPF ou senha incorretos." });

            return Ok(new
            {
                mensagem = "Login realizado com sucesso!",
                usuarioId = usuario.Id,
                apelido = usuario.Apelido,
                proximaTela = "../telaNome/index.html"
            });
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> Cadastro([FromBody] CadastroDto dto)
        {
            var existe = await _context.Usuarios
                .AnyAsync(u => u.Cpf == dto.Cpf);

            if (existe)
                return BadRequest(new { mensagem = "CPF já cadastrado." });

            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Cpf = dto.Cpf,
                Senha = dto.Senha,
                Apelido = dto.Nome,
                SenhaGrafico = dto.SenhaGrafico,
                FotoPerfil = dto.FotoPerfil
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Cadastro realizado com sucesso!" });
        }

        [HttpPost("verificarSenhaGrafico")]
        public async Task<IActionResult> VerificarSenhaGrafico([FromBody] VerificarSenhaDto dto)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Id == dto.UsuarioId && u.Senha == dto.Senha);

            if (usuario == null)
                return Unauthorized(new { mensagem = "Senha incorreta." });

            return Ok(new { mensagem = "Acesso autorizado." });
        }
    }
}