using System.Diagnostics;

public class Aluno
{
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
}

public static class CalculadoraMedia
{
    public static double CalcularMedia(Aluno aluno)
    {
        return (aluno.Nota1 + aluno.Nota2 + aluno.Nota3) / 3.0;
    }
}

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
partial class Program
{
    static void Main()
    {
        var aluno = new Aluno { Nota1 = 8.5, Nota2 = 7.0, Nota3 = 9.0 };
        double media = (aluno.Nota1 + aluno.Nota2 + aluno.Nota3) / 3.0;
        System.Console.WriteLine(media);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
