
/*
 Aplica��o com thread ASS�NCRONA
 */

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/request", async () =>
{
    var start = DateTime.Now;
    Console.WriteLine($"new request! {start}");
    var second = 1000;
    /* Na vers�o ass�ncrona com Task.Delay, as requisi��es podem ser processadas
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
 Aplica��o com thread S�NCRONA
 */

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.UseHttpsRedirection();
//app.MapGet("/request", () =>
//{
//    var start = DateTime.Now;
//    Console.WriteLine($"new request! {start}");
//    var second = 1000;
//    /* Na vers�o sincrona com Thread.Sleep, cada requisi��o vai bloquear a thread,
//    e m�ltiplas requisi��es simult�neas podem ficar lentas ou at� travar.*/
//    Thread.Sleep(second * 10);
//    var end = DateTime.Now;
//    var message = $"Sucesso! {start} | {end} | {end - start}";
//    Console.WriteLine(message);
//    return message;
//});

//app.Run();
