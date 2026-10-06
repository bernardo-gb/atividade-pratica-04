using RestauranteMVC.Models;

@model List<RestauranteMVC.Models.Prato>

<h1>Cardápio</h1>

<table class= "table" >
    < thead >
        < tr >
            < th > Prato </ th >
            < th > Descrição </ th >
            < th > Preço </ th >
        </ tr >
    </ thead >

    < tbody >
        @foreach(var prato in Model)
        {
            < tr >
                < td > @prato.Nome </ td >
                < td > @prato.Descricao </ td >
                < td > R$ @prato.Preco.ToString("N2") </ td >
            </ tr >
        }
    </ tbody >
</ table >
