using SuaNamespace;

namespace SuaNamespace
{
    public class Pedido
    {
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }

    public static class PedidoUtils
    {
        public static decimal CalcularTotal(Pedido pedido)
        {
            return pedido.Quantidade * pedido.PrecoUnitario;
        }
    }

    public class Program
    {
        public static void Main()
        {
            var pedido = new Pedido { Quantidade = 2, PrecoUnitario = 10m };
            decimal total = PedidoUtils.CalcularTotal(pedido);
            Console.WriteLine(total);
        }
    }
}
