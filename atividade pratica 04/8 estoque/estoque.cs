using ProdutosMVC.Models;

public partial class Program
{
    private static void Main(string[] args, object produtoObj, string situacao)
    {
        var produto = produtoObj as Produto;
        if (produto == null) return; // ou trate o erro

        if (produto.Estoque != 0)
        {
            if (produto.Estoque <= produto.EstoqueMinimo)
                situacao = "ESTOQUE BAIXO";
            else
                situacao = "ESTOQUE NORMAL";
        }
        else situacao = "ESGOTADO";
    }
}