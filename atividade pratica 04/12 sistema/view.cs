@model List<LojaMVC.Models.Produto>

<h1>Loja de Produtos</h1>

<table class= "table" >
    < thead >
        < tr >
            < th > Produto </ th >
            < th > Preço </ th >
            < th > Estoque </ th >
            < th > Situação </ th >
        </ tr >
    </ thead >

    < tbody >
        @foreach(var produto in Model)
        {
            < tr >
                < td > @produto.Nome </ td >
                < td > R$ @produto.Preco.ToString("N2") </ td >
                < td > @produto.Estoque </ td >
                < td >
                    @if(produto.Estoque > 0)
                    {
                        < span class= "text-success" > Disponível </ span >
                    }
                    else
{
                        < span class= "text-danger" > Esgotado </ span >
                    }
                </ td >
            </ tr >
        }
    </ tbody >
</ table >
