using System;
using RecipeMaker.Controllers;
using RecipeMaker.Factories;
using RecipeMaker.Models;
using RecipeMaker.Views;

public class Program
{
    public static void Main(string[] args)
    {
        IFabricaReceita fabrica = new FabricaShari();
        var view = new ConsoleView();
        var controller = new ReceitaController(fabrica, view);
        controller.Executar();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
