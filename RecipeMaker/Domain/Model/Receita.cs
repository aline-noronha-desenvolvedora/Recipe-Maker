using System;
using System.Collections.Generic;

namespace RecipeMaker.Models;

public class Receita
{
    public string Nome { get; }
    public List<Ingrediente> Ingredientes { get; }
    
    public IModoPreparo ModoPreparo { get; set; }

    public Receita(
        string nome,
        List<Ingrediente> ingredientes)
    {
        Nome = nome;
        Ingredientes = ingredientes;
    }

    public void Preparar()
    {
        if (ModoPreparo == null)
        {
            throw new InvalidOperationException("Modo de preparo não definido");
        }
        
        ModoPreparo.ExecutarReceita(this);
    }
}