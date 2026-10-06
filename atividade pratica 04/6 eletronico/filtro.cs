using Microsoft.AspNetCore.Mvc;

public IActionResult Baratos()
{
    var produtos = lista
        .Where(x => x.Preco < 1000)
        .ToList();

    return View("Index", produtos);
}
