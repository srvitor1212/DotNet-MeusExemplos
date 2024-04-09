using OfficeOpenXml;
using OfficeOpenXml.Core.ExcelPackage;

string ARQUIVO = "03_03_10_13.xlsx";

// Certifique-se de que o nome da planilha é válido
if (ARQUIVO.Length > 31 || ARQUIVO.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
{
    Console.WriteLine("Nome de planilha inválido.");
    return;
}

// Criar uma instância do ExcelPackage
using (var package = new ExcelPackage(new FileInfo(ARQUIVO)))
{
    // Adicionar uma nova planilha ao arquivo Excel
    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(ARQUIVO);

    // Faça qualquer outra manipulação de dados ou formatação necessária aqui

    // Salvar o arquivo Excel
    package.Save();
}
