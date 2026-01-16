namespace RecipeMaker.Chain;

public abstract class PassoBase: IPassoHandler
{
    public IPassoHandler? _proximo;
    
    public IPassoHandler SetPasso(IPassoHandler proximo)
    {
        _proximo = proximo;
        return _proximo;
    }

    public void Executar()
    {
        ExecutarPasso();
        _proximo?.Executar();
    }

    public abstract void ExecutarPasso();
}