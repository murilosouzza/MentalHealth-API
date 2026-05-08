namespace MentalHealth_.Models
{
    public class Pesquisa
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int QualidadeSono { get; set; }
        public string Medicacao { get; set; } = string.Empty;
        public int Disposicao { get; set; }
        public string Ansiedade { get; set; } = string.Empty;
        public string? Relato { get; set; }
        public DateTime Data { get; set; } = DateTime.UtcNow;
        public Usuario? Usuario { get; set; }
    }
}