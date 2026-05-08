namespace MentalHealth_.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string? Apelido { get; set; }
        public string? SenhaGrafico { get; set; }
        public string? FotoPerfil { get; set; }
    }
}