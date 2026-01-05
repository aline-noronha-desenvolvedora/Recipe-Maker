namespace RecipeMaker.Models;

public class Receita
{
    public string Nome { get; }
    public List<Ingrediente> Ingredientes { get; }
    public List<Passo> Passos { get; }

    public Receita(
        string nome,
        List<Ingrediente> ingredientes,
        List<Passo> passos)
    {
        Nome = nome;
        Ingredientes = ingredientes;
        Passos = passos;
    }
}