namespace MentalHealth_.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Humor { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.UtcNow;
        public Usuario? Usuario { get; set; }
    }
}