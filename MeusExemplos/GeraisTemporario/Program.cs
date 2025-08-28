namespace geral;

class Program
{
    static void Main(string[] args)
    {
        var insertIntoUsedRoutes = "INSERT INTO PaymentConferenceSummaryRoute (PaymentConferenceSummariesId,UsedRoutesId)";

        var valuesUsedRoutes = new List<string>();

        for (int i = 0; i < 1578; i++)
        {
            valuesUsedRoutes.Add($"('{i + 1}', '{i + 1}')");
        }


        insertIntoUsedRoutes = ConcatHelper(insertIntoUsedRoutes, [.. valuesUsedRoutes]);
        //insertIntoUsedRoutes = ConcatHelper(insertIntoUsedRoutes, "teste");
        Console.WriteLine(insertIntoUsedRoutes);
    }

    private static string ConcatHelper(string insertInto, string value)
    {
        return ConcatHelper(insertInto, [value]);
    }

    private static string ConcatHelper(string insertInto, IEnumerable<string> values)
    {
        if (!values.Any())
            return string.Empty;

        const int batchSize = 1000;



        var batchedInserts = values
            .Select((value, index) => new { value, index })
            .GroupBy(x => x.index / batchSize)
            .Select(group => $"{insertInto} VALUES {string.Join(", ", group.Select(g => g.value))};");

        return string.Join(" ", batchedInserts);
    }
}
