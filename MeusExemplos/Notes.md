

# Threads e Tasks
> Um processo tem várias threads. Uma thread pode executar várias tasks, mas uma task não é uma thread — ela é um agendamento de trabalho que pode (ou não) usar uma thread do pool.

O uso de async/await não garante que o processo vai ser executado de forma paralela. 

Quando a execução chega em um comando await(aguardar), e a carga a ser executada é do tipo I/O, então a thread atual se libera para atender outros processamentos.

Porém é criado um agendamento para que essa thread retorne quando esse await terminar.

Exemplo:
```
public async Task<CarrosResponse> Consultar()
{
    var carros = await _carroRepository.GetQueryable();

    return carros;
}
```

Já no caso de ser uma carga do tipo CPU-Bound, a thread fica presa pois está executando o processamento.

Exemplo:
```
public async Task<string> Consultar(int seconds, Guid taskId)
{
    for (long i = 0; i < 900_000_000; i++)
        rand.Next();
}
```

CPU-Bound → Quando a limitação está no processador. O programa gasta tempo calculando, processando dados ou rodando algoritmos pesados.

IO-Bound → Quando a limitação está em entrada/saída. O programa passa tempo esperando disco, rede, banco de dados ou arquivos.







