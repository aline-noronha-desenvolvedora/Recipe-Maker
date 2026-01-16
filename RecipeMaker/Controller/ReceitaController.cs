using System;
using RecipeMaker.Chain.Passos;
using RecipeMaker.Models;
using RecipeMaker.Views;

namespace RecipeMaker.Controllers;

public class ReceitaController
{
    public void ExecutarShari()
    {
        Console.WriteLine("Receita: Shari (Tempero para arroz de sushi)");
        Console.WriteLine("Modo de preparo:\n");
        
        var misturar = new MisturarIngredientesPasso();
        var aquecer = new AquecerMisturaPassso();
        var finalizar = new FinalizarPasso();

        misturar.SetPasso(aquecer)
            .SetPasso(finalizar);
        
        misturar.Executar();
    }
}