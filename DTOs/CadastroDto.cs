namespace MentalHealth_.DTOs
{
    public class CadastroDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string? SenhaGrafico { get; set; }
        public string? FotoPerfil { get; set; }
    }
}