using System;

namespace RecipeMaker.Chain.Passos;

public class MisturarIngredientesPasso : PassoBase
{
    public override void ExecutarPasso()
    {
        Console.WriteLine("Misturando açúcar, sal e vinagre de arroz.");
    }
}