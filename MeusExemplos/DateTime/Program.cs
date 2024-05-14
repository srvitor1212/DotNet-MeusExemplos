using DateTime_Ex;


Console.WriteLine("==== Tratando datas null e zeradas/inválidas (ex.: 00/00/0000 00:00)");
string str1 = "00/00/0000 00:00";
string? str2 = null;
string str3 = "";

var convert = new Date_Time();
Console.WriteLine("str1 = " + convert.StringToDatetime(str1) + "\n");
Console.WriteLine("str2 = " + convert.StringToDatetime(str2) + "\n");
Console.WriteLine("str3 = " + convert.StringToDatetime(str3) + "\n");