
/*
 Aplicação com thread ASSÍNCRONA
 */

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/request", async () =>
{
    var start = DateTime.Now;
    Console.WriteLine($"new request! {start}");
    var second = 1000;
    /* Na versão assíncrona com Task.Delay, as requisições podem ser processadas
     * de forma mais eficiente, sem bloquear threads do servidor.*/
    await Task.Delay(second * 10);
    var end = DateTime.Now;
    var message = $"Sucesso! {start} | {end} | {end - start}";
    Console.WriteLine(message);
    return message;
});

await app.RunAsync();

//--------------------------------------------------------------------------------------------

/*
 Aplicação com thread SÍNCRONA
 */

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.UseHttpsRedirection();
//app.MapGet("/request", () =>
//{
//    var start = DateTime.Now;
//    Console.WriteLine($"new request! {start}");
//    var second = 1000;
//    /* Na versão sincrona com Thread.Sleep, cada requisição vai bloquear a thread,
//    e múltiplas requisições simultâneas podem ficar lentas ou até travar.*/
//    Thread.Sleep(second * 10);
//    var end = DateTime.Now;
//    var message = $"Sucesso! {start} | {end} | {end - start}";
//    Console.WriteLine(message);
//    return message;
//});

//app.Run();
