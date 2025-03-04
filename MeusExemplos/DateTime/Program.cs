﻿using DateTime_Ex;


Console.WriteLine("==== Tratando datas null e zeradas/inválidas (ex.: 00/00/0000 00:00)");
string str1 = "00/00/0000 00:00";
string? str2 = null;
string str3 = "";
string str4 = "25/11/2024 12:44:00";

var convert = new Date_Time();
Console.WriteLine("str1 = " + convert.StringToDatetime(str1) + "\n");
Console.WriteLine("str2 = " + convert.StringToDatetime(str2) + "\n");
Console.WriteLine("str3 = " + convert.StringToDatetime(str3) + "\n");
Console.WriteLine("str4 = " + convert.StringToDatetime(str4) + "\n");


Console.WriteLine("======================================");

Console.WriteLine($" ...........DateTime.Now: {DateTime.Now}");
Console.WriteLine($" ........DateTime.UtcNow: {DateTime.UtcNow}");
Console.WriteLine($" .....DateTimeOffset.Now: {DateTimeOffset.Now}");
Console.WriteLine($" ..DateTimeOffset.UtcNow: {DateTimeOffset.UtcNow}");


Console.WriteLine("\n==== Testar data =========================");

var verificarDataHora = new VerificarDateTime();
Console.WriteLine($"ao instânciar.......: {verificarDataHora.DataHora}");

verificarDataHora.SetDataHora(DateTime.Now);
Console.WriteLine($"ao passar errado....: {verificarDataHora.DataHora}");

verificarDataHora.SetUniversalTime(DateTime.Now);
Console.WriteLine($"convertendo sempre..: {verificarDataHora.DataHora}");


