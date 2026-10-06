using HotelMVC.Models;

@model List<HotelMVC.Models.Quarto>

<h1>Hotel MVC</h1>

<p>Confira nossas opções de hospedagem.</p>

<table class= "table" >
    < thead >
        < tr >
            < th > Quarto </ th >
            < th > Capacidade </ th >
            < th > Descrição </ th >
            < th > Diária </ th >
        </ tr >
    </ thead >

    < tbody >
        @foreach(var quarto in Model)
        {
            < tr >
                < td > @quarto.Nome </ td >
                < td > @quarto.Capacidade pessoas </ td >
                < td > @quarto.Descricao </ td >
                < td > R$ @quarto.Diaria.ToString("N2") </ td >
            </ tr >
        }
    </ tbody >
</ table >
