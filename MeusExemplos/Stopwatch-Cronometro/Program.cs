


using System.Diagnostics;

var cronometro = new Stopwatch();


//uso
cronometro.Start();
Thread.Sleep(1000);
cronometro.Stop();

//mostrar o tempo decorrido
Console.WriteLine(cronometro);
Console.WriteLine(cronometro.Elapsed);

//formatar o tempo decorrido
var ts = cronometro.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);