using Microsoft.AspNetCore.Mvc;

public IActionResult Cachorros()
{
    return View("Index", animais
        .Where(x => x.Especie == "Cachorro")
        .ToList());
}

public IActionResult Gatos()
{
    return View("Index", animais
        .Where(x => x.Especie == "Gato")
        .ToList());
}
