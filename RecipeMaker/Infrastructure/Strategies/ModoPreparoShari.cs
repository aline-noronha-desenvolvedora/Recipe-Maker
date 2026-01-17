using System;
using RecipeMaker.Chain.Passos;
using RecipeMaker.Models;

namespace RecipeMaker.Strategies;

public class ModoPreparoShari : IModoPreparo
{
    public void ExecutarReceita(Receita receita)
    {
        var mistura = new MisturarIngredientesPasso();
        var aquecer = new AquecerMisturaPassso();
        var finalizar = new FinalizarPasso();

        mistura.
            SetPasso(aquecer).
            SetPasso(finalizar);
        
        mistura.Executar();
    }
}