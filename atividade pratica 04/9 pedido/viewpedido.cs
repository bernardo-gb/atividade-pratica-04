using SuaNamespace;

var preparo = pedidos
    .Where(x => x.Status == "Em preparo")
    .ToList();

var prontos = pedidos
    .Where(x => x.Status == "Pronto")
    .ToList();

var entregues = pedidos
    .Where(x => x.Status == "Entregue")
    .ToList();
