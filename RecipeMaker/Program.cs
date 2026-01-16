using System;
using RecipeMaker.Controllers;
using RecipeMaker.Factories;
using RecipeMaker.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var controller = new ReceitaController();
        controller.ExecutarShari();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
