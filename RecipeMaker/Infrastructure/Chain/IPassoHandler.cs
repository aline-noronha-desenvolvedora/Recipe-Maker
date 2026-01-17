namespace RecipeMaker.Chain;

public interface IPassoHandler
{
    IPassoHandler SetPasso(IPassoHandler passoHandler);
    void Executar();
}