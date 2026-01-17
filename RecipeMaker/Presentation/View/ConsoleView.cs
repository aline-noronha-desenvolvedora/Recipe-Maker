using System;
using System.Collections.Generic;
using System.Linq;
using RecipeMaker.Models;

namespace RecipeMaker.Views;

public class ConsoleView
{
    public void MostrarMenu(List<Receita> receitas)
    {
        Console.WriteLine("🍣 Bem-vindo ao Recipe Maker!");
        Console.WriteLine();

        for (int i = 0; i < receitas.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {receitas[i].Nome}");
        }
    }

    public int LerEscolha()
    {
        Console.WriteLine();
        Console.Write("Escolha uma receita: ");
        return int.Parse(Console.ReadLine()!);
    }

    public void MostrarReceita(Receita receita)
    {
        Console.Clear();
        Console.WriteLine($"🍱 Receita: {receita.Nome}");
        Console.WriteLine();

        Console.WriteLine("Ingredientes:");
        foreach (var ingrediente in receita.Ingredientes)
        {
            Console.WriteLine($"- {ingrediente.Quantidade} de {ingrediente.Nome}");
        }

        Console.WriteLine();
        Console.WriteLine("Modo de preparo:");
    }
}