using Tasks;


var id = Guid.NewGuid();
Log.Write(id, "Principal inicio");



var cozinheiroVitor =
    new Thread(() =>
    {
        var idT1 = Guid.NewGuid();
        Log.Write(idT1, "Thread Cozinhar arroz - inicio");

        Thread.Sleep(5 * 1000);

        Log.Write(idT1, "Thread Cozinhar arroz - fim");
    })
    {
        Name = "Cozinhar arroz"
    };

var cozinheiroJoao =
    new Thread(() =>
    {
        var idT2 = Guid.NewGuid();
        Log.Write(idT2, "Thread Fritar a carne - inicio");


        for (int i = 0; i < 10; i++)
        {
            Log.Write(idT2, $"Fritou o bife {i}");
            Thread.Sleep(1 * 1000);
        }


        Log.Write(idT2, "Thread Fritar a carne - fim");
    })
    {
        Name = "Fritar a carne",
        //IsBackground = true, // quando todas as tasks foreground terminam, as background são eliminadas

    };

Log.Write(id, "Start nas threads");
cozinheiroVitor.Start();
cozinheiroJoao.Start();
Log.Write(id, "Startou as threads");



Log.Write(id, "Principal fim");


