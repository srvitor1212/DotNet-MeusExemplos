

var cozinheiroVitor = new Thread(() =>
{
    Console.WriteLine($"{DateTime.Now} {Thread.CurrentThread.Name} - Colocou o arroz na panela");
    Console.WriteLine($"{DateTime.Now} {Thread.CurrentThread.Name} - Ligou o fogão");
    Thread.Sleep(5 * 1000);
    Console.WriteLine($"{DateTime.Now} {Thread.CurrentThread.Name} - Arroz cozido!");

})
{
    Name = "Cozinhar arroz"
};

var cozinheiroJoao = new Thread(() =>
{
    Console.WriteLine($"{DateTime.Now} {Thread.CurrentThread.Name} - Temperou a carne");
    Console.WriteLine($"{DateTime.Now} {Thread.CurrentThread.Name} - Ligou o fogão");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{DateTime.Now} {Thread.CurrentThread.Name} - Fritou o bife {i}");
        Thread.Sleep(1 * 1000);
    }
    Console.WriteLine($"{DateTime.Now} {Thread.CurrentThread.Name} - Carne assada!");

})
{
    Name = "Fritar a carne",
    //IsBackground = true, // quando todas as tasks foreground terminam, as background são eliminadas

};

Console.WriteLine("Start nas threads");
cozinheiroVitor.Start();
cozinheiroJoao.Start();
Console.WriteLine("Startou as threads");

