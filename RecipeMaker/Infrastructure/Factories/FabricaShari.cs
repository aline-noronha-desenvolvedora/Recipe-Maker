using System.Collections.Generic;
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
        
        var receita = new Receita(
            "Shari (Tempero para arroz de sushi)",
            ingredientes
        );

        receita.ModoPreparo = new ModoPreparoShari();

        return receita;
    }
}