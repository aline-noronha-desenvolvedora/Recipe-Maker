namespace RecipeMaker.Models;

public class Passo
{
    public int Ordem { get; }
    public string Descricao { get; }

    public Passo(int ordem, string descricao)
    {
        Ordem = ordem;
        Descricao = descricao;
    }
}