namespace FilmesMVC.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Genero { get; set; } = "";
        public int Duracao { get; set; }
    }
}
