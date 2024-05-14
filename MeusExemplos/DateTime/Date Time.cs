using System.Globalization;

namespace DateTime_Ex
{
    internal class Date_Time
    {
        public DateTime StringToDatetime(string value)
        {


            //trata se for null ou spaces
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine(">>é nula ou espaços");
                return DateTime.MinValue;
            }


            //tenta converter a string para datetime
            CultureInfo cultureInfo = new CultureInfo("pt-BR");
            if (DateTime.TryParse(value, cultureInfo, out var result))
            {
                Console.WriteLine(">>não foi possível converter");
                return result;
            }

            Console.WriteLine(">>retorno default");
            return DateTime.MinValue;
        }
    }
}
