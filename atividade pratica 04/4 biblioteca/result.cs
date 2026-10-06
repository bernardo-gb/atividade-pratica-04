using Microsoft.AspNetCore.Mvc;

public partial class Program
{
    private static void Main(string[] args)
    {
        // código existente de inicialização...
    }

    public IActionResult Disponiveis()
    {
        var livros = lista.Where(x => x.Disponivel).ToList();
        return View("Index", livros);
    }
}