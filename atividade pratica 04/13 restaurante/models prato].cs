namespace RestauranteMVC.Models
{
    public class Prato
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Descricao { get; set; } = "";
        public double Preco { get; set; }
    }
}
