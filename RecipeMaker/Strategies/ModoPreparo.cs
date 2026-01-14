using RecipeMaker.Models;

namespace RecipeMaker.Strategies;

public class ModoPreparo : IModoPreparo
{
    public void ExecutarReceita(Receita receita)
    {
        Console.WriteLine("Modo de preparo simples:");

        foreach (var passo in receita.Passos)
        {
            Console.WriteLine($" Passo: {passo.Ordem}, Ordem: {passo.Descricao}");
        }
    }
}