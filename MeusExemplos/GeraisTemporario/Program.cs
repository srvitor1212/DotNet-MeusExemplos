

double cost = 123423.083234;
Console.WriteLine(cost.ToString("C",new System.Globalization.CultureInfo("pt-BR")));
Console.WriteLine(cost.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR")));