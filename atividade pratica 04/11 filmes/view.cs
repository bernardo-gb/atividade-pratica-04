using FilmesMVC.Models;

@model List<FilmesMVC.Models.Filme>

<h1>Filmes em Cartaz</h1>

<table class= "table" >
    < thead >
        < tr >
            < th > Filme </ th >
            < th > Gênero </ th >
            < th > Duração </ th >
        </ tr >
    </ thead >

    < tbody >
        @foreach(var filme in Model)
        {
            < tr >
                < td > @filme.Nome </ td >
                < td > @filme.Genero </ td >
                < td > @filme.Duracao minutos </ td >
            </ tr >
        }
    </ tbody >
</ table >
