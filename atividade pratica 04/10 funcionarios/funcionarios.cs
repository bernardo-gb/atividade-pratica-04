public partial class Program
{
    // Renomeado para evitar conflito com outra Main no projeto
    private static void MainProgram(string[] args)
    {
        IEnumerable<Funcionario> funcionarios = ObterFuncionarios();
        var ativos = funcionarios.Where(x => x.Ativo).ToList();
        var inativos = funcionarios.Where(x => !x.Ativo).ToList();
    }

    private static IEnumerable<Funcionario> ObterFuncionarios()
    {
        return new List<Funcionario>();
    }
}