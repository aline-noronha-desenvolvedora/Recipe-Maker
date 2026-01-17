using System;
using System.Collections.Generic;
using RecipeMaker.Chain.Passos;
using RecipeMaker.Models;
using RecipeMaker.Views;

namespace RecipeMaker.Controllers;

public class ReceitaController
{
    public readonly IFabricaReceita _fabrica;
    public readonly ConsoleView _view;

    public ReceitaController(IFabricaReceita fabrica, ConsoleView view)
    {
        _fabrica = fabrica;
        _view = view;
    }
    public void Executar()
    {
        var receitas = new List<Receita>()
        {
            _fabrica.Criar()
        };
        
        _view.MostrarMenu(receitas);

        var escolha = _view.LerEscolha();

        var receita = receitas[escolha -1];
        
        _view.MostrarReceita(receita);
        
        receita.Preparar();
    }
}