internal class Program
{
    private static void Main(string[] args)
    {
        float nota2, nota5, nota10, nota20, nota50, nota100;
        float conta, troco, pago;

        Console.WriteLine("Informe o valor da conta: ");
        conta = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor pago: ");
        pago = float.Parse(Console.ReadLine());

        troco = pago - conta;

        Console.WriteLine("Troco: R$ {0}", troco.ToString("f2"));

        nota2 = troco / 2;
        nota5 = troco / 5;
        nota10 = troco / 10;
        nota20 = troco / 20;
        nota50 = troco / 50;
        nota100 = troco / 100;

        Console.WriteLine("\nNotas possíveis para devolução:" + "\n{0} notas de R$ 2,00"
            + "\n{1} notas de R$ 5,00"
            + "\n{2} notas de 10,00"
            + "\n{3} notas de 20,00"
            + "\n{4} notas de 50,00"
            + "\n{5} notas de 100,00", nota2, nota5, nota10, nota20, nota50, nota100);
    }
}