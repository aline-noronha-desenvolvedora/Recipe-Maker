using RecipeMaker.Controllers;
using RecipeMaker.Factories;
using RecipeMaker.Models;

IFabricaReceita fabricaReceita = new FabricaShari();
var controller = new ReceitaController(fabricaReceita);

var receita = controller.ObterReceita();

Console.WriteLine($"Receita : {receita.Nome}");