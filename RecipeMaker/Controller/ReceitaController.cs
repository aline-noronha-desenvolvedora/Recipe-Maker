using RecipeMaker.Models;
using RecipeMaker.Views;

namespace RecipeMaker.Controllers;

public class ReceitaController
{
    private readonly ConsoleView _view;
    private readonly List<Receita> _receitas;

    public ReceitaController()
    {
        _view = new ConsoleView();
        _receitas = CriarReceitas();
    }

    public void Iniciar()
    {
        _view.MostrarMenu(_receitas);
        var escolha = _view.LerEscolha();

        var receita = _receitas[escolha - 1];
        _view.MostrarReceita(receita);
    }

    private List<Receita> CriarReceitas()
    {
        return new List<Receita>
        {
            new Receita(
                "Shari (Tempero do arroz de sushi)",
                new List<Ingrediente>
                {
                    new Ingrediente("Vinagre de arroz", "1/2 xícara"),
                    new Ingrediente("Açúcar", "2 colheres de sopa"),
                    new Ingrediente("Sal", "1 colher de chá")
                },
                new List<Passo>
                {
                    new Passo(1, "Misture o vinagre, o açúcar e o sal em uma panela."),
                    new Passo(2, "Leve ao fogo baixo até dissolver completamente."),
                    new Passo(3, "Não deixe ferver."),
                    new Passo(4, "Deixe esfriar antes de usar no arroz.")
                }
            )
        };
    }
}