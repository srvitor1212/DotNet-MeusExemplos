

namespace POO_Static
{
    public class ClassMembrosStaticos
    {
        public static double Pi = 3.14;
        public double Pi_Liberado = 3.14;

        public static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
        public double Volume_Liberado(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}
