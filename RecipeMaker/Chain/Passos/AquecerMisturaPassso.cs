using System;

namespace RecipeMaker.Chain.Passos;

public class AquecerMisturaPassso : PassoBase
{
    public override void ExecutarPasso()
    {
        Console.WriteLine("Aquecendo a mistura em fogo baixo (não ferver).");
    }
}