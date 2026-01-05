namespace RecipeMaker.Models;

public class Ingrediente
{
    public string Nome { get; }
    public string Quantidade { get; }

    public Ingrediente(string nome, string quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }
}