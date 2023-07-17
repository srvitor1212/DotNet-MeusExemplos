

namespace POO_Simples
{
    public class MinhaClasse
    {
        //prop + TAB
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return 
                $"O nome é {Name}.\n" +
                $"A idade é {Age}.";
        }
    }
}
