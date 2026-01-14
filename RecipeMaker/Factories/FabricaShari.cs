using RecipeMaker.Models;
using RecipeMaker.Strategies;

namespace RecipeMaker.Factories;

public class FabricaShari : IFabricaReceita
{
    public Receita Criar()
    {
        var ingredientes = new List<Ingrediente>
        {
            new Ingrediente("Vinagre de arroz", "100 ml"),
            new Ingrediente("Açúcar", "2 colheres de sopa"),
            new Ingrediente("Sal", "1 colher de chá")
        };

        var passos = new List<Passo>
        {
            new Passo(1, "Misture todos os ingredientes"),
            new Passo(2, "Aqueça levemente até dissolver o açúcar e o sal"),
            new Passo(3, "Deixe esfriar antes de usar no arroz")
        };
        
        var receita = new Receita(
            "Shari (Tempero para arroz de sushi)",
            ingredientes,
            passos
        );

        receita._ModoPreparo = new ModoPreparo();

        return receita;
    }
}