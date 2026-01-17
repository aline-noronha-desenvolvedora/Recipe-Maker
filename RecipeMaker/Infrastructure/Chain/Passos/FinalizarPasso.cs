using System;

namespace RecipeMaker.Chain.Passos;

public class FinalizarPasso : PassoBase
{
    public override void ExecutarPasso()
    {
        Console.WriteLine("Desligue o fogo, deixe esfriar e estará pronto.");
    }
}