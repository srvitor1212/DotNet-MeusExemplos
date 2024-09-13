namespace SOLID.SRP;


public class PedidoErradoSRP()
{
    public void RegistrarPedido()
    {
        try
        {
            GravarPedido();

            EnviarEmail(); //Viola o principio SRP, não tem a ver com a classe
        }
        catch (Exception e)
        {
            LogErro(e); //Viola o principio SRP, não tem a ver com a classe

            RemoverPedido();
        }
    }

    private static bool GravarPedido() => true;

    private static bool RemoverPedido() => true;

    private static bool EnviarEmail() => true;

    private static bool LogErro(Exception e) => true;
}