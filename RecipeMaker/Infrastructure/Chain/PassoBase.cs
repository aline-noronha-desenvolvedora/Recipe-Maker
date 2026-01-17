namespace RecipeMaker.Chain;

public abstract class PassoBase: IPassoHandler
{
    public IPassoHandler Proximo;
    
    public IPassoHandler SetPasso(IPassoHandler proximo)
    {
        this.Proximo = proximo;
        return Proximo;
    }

    public void Executar()
    {
        ExecutarPasso();
        Proximo?.Executar();
    }

    public abstract void ExecutarPasso();
}