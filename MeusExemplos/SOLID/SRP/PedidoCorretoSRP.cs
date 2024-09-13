using SOLID.SRP.Interface;

namespace SOLID.SRP;

public class PedidoCorretoSRP
{
    private readonly IEmail _email;
    private readonly ILog _log;

    public PedidoCorretoSRP(IEmail email, ILog log)
    {
        _email = email;
        _log = log;
    }

    public void RegistrarPedido()
    {
        try
        {
            GravarPedido();

            _email.EnviarEmail(); //Como se trata de outra finalidade, está separado
        }
        catch (Exception e)
        {
            _log.GravarLog();   //Como se trata de outra finalidade, está separado

            RemoverPedido();
        }
    }

    private static bool GravarPedido() => true;

    private static bool RemoverPedido() => true;

}
