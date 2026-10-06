using ProdutosMVC.Models;
using System.Runtime.ConstrainedExecution;

@model List<ProdutosMVC.Models.Produto>

<h1>Produtos</h1>

<table class= "table" >
    < tr >
        < th > Nome </ th >
        < th > Categoria </ th >
        < th > Estoque </ th >
        < th > Preço </ th >
        < th > Situação </ th >
    </ tr >

    @foreach(var produto in Model)
    {
        < tr >
            < td > @produto.Nome </ td >
            < td > @produto.Categoria </ td >
            < td > @produto.Estoque </ td >
            < td > R$ @produto.Preco </ td >

            < td >
                @if(produto.Estoque == 0)
                {
                    < span style = "color:red" > Produto esgotado </ span >
                }
                else
    {
                    < span style = "color:green" > Disponível </ span >
                }
            </ td >
        </ tr >
    }
</ table >

< a asp - action = "Disponiveis" > Ver produtos disponíveis</a>
