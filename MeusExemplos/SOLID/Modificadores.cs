namespace SOLID;

public class Modificadores
{
    public Modificadores()
    {
        Console.WriteLine(@"
            MODIFICADORES DE ACESSO
 
            public:                 acesso não é restrito.

            private:                acesso é limitado à classe.

            protected:              acesso é limitado à classe que os contém ou aos tipos derivados(que herdam).

            internal:               acesso é limitado ao assembly atual.    

            protected internal:     acesso é limitado ao assembly atual ou aos tipos derivados(que herdam).    

            private protected:      acesso é limitado à classe que o contém ou a tipos derivados da classe que o contém no assembly atual.




            OUTROS MODIFICADORES

            static
                Podem ser acessados sem instânciar a classe, exemplo: Console.WriteLine(""Hello World!"");

            interface
                É uma classe completamente abstrada, só pode conter métodos e propriedades abstratas. Serve como um contrato.

            abstract 
                Parecido com uma interface, mas pode conter métodos e propriedades não abstratos.
                classe:     A classe não pode ser instânciada(tornar-se objeto). Precisa que outra classe herde ela para poder instânciar.
                método:     Só pode ser usado em uma classe abstrada. Não precisa de corpo, o corpo pode ser feito na classe que herdou. Serve como um contrato a seguir.

            sealed
                classe: Ao informar na classe ela não pode ser herdada.
                método: Imprede que seja sobre escrito(override)
                propriedade: Imprede que seja sobre escrito(override)
        ");
    }
}
