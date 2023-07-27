

namespace MeuNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            int QTD_INDICES = 10000;
            string TEXTO = "Uma string qualquer para testes";

            string[] meuArray;
            List<string> meuList;

            // Preparar o ARRAY
            meuArray = new string[QTD_INDICES];
            for (int i = 0; i < QTD_INDICES; i++)
                meuArray[i] = TEXTO;

            // Preparar o LIST
            meuList = new List<string>();
            for (int i = 0;i < QTD_INDICES;i++)
            {
                meuList.Add(TEXTO);
            }

            //todo: testar performance de um e de outro
        }
    }
}