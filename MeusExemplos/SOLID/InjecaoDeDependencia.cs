namespace SOLID;

public class InjecaoDeDependencia
{
    private readonly DependenciaASerInjetada _dependenciaASerInjetada;

    public InjecaoDeDependencia(DependenciaASerInjetada dependenciaASerInjetada)
    {
        _dependenciaASerInjetada = dependenciaASerInjetada;
    }

    public bool VerificaValor(int valor)
    {
        var calculado = _dependenciaASerInjetada.Calculo();

        return valor > calculado;
    }
}




public class DependenciaASerInjetada()
{
    public int Calculo()
    {
        Random rnd = new Random();

        return rnd.Next(15);
    }
}