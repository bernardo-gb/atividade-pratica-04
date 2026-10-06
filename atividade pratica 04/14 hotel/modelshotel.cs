namespace HotelMVC.Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public int Capacidade { get; set; }
        public string Descricao { get; set; } = "";
        public decimal Diaria { get; set; }
    }
}
