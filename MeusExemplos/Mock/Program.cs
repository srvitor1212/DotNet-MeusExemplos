

using Moq;



public interface IClasseMock
{
    public DateTime RetornaDataHoje();
}



public class ClasseMock : IClasseMock
{
    public DateTime RetornaDataHoje()
    {
        return DateTime.Now;
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        var dataAgora = new ClasseMock().RetornaDataHoje();
        Console.WriteLine("Sem o mock: {0}", dataAgora);


        var dataMock = new DateTime(2022, 4, 1);
        var objMock = new Mock<IClasseMock>();
        objMock
            .Setup(x => x.RetornaDataHoje())
            .Returns(dataMock);
        var objTeste = objMock.Object;
        Console.WriteLine("Mockando a classe: {0}", objTeste.RetornaDataHoje());
    }
}