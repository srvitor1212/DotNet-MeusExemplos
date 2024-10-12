namespace Application.Responses.Records;

public class MotoristasRecordResponse()
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Situacao { get; set; }
    public string TipoHabilitacao { get; set; }

    public MotoristasRecordResponse(Guid id, //todo
                                    string nome,
                                    string situacao,
                                    string tipoHabilitacao)
    {
        Id = id;
        Nome = nome;
        Situacao = situacao;
        TipoHabilitacao = tipoHabilitacao;
    }
};