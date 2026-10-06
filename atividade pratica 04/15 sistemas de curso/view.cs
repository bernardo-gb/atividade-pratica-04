using CursosMVC.Models;

@model List<CursosMVC.Models.Curso>

<h1>Cursos Disponíveis</h1>

<table class= "table" >
    < thead >
        < tr >
            < th > Curso </ th >
            < th > Carga Horária </ th >
            < th > Modalidade </ th >
            < th > Vagas </ th >
            < th > Valor </ th >
            < th > Situação </ th >
        </ tr >
    </ thead >

    < tbody >
        @foreach(var curso in Model)
        {
            < tr >
                < td > @curso.Nome </ td >
                < td > @curso.CargaHoraria horas </ td >
                < td > @curso.Modalidade </ td >
                < td > @curso.Vagas </ td >
                < td > R$ @curso.Valor.ToString("N2") </ td >

                < td >
                    @if(curso.Vagas > 0)
                    {
                        < span class= "text-success" >
                            Inscrições abertas
                        </ span >
                    }
                    else
{
                        < span class= "text-danger" >
                            Turma lotada
                        </ span >
                    }
                </ td >
            </ tr >
        }
    </ tbody >
</ table >
