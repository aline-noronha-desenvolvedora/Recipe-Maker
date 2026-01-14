using RecipeMaker.Models;
using RecipeMaker.Views;

namespace RecipeMaker.Controllers;

public class ReceitaController
{
    private readonly IFabricaReceita _fabrica;

    public ReceitaController(IFabricaReceita fabrica)
    {
        _fabrica = fabrica;
    }

    public Receita ObterReceita()
    {
        return _fabrica.Criar();
    }
}