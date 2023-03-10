namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a KM inicial");
            decimal a1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe a KM Final");
            decimal a2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Consumo de combustivel");
            decimal f1 = Convert.ToDecimal(Console.ReadLine());

            decimal res = a2 - a1;

            res = Math.Round(res / f1, 1);
            Console.WriteLine("O carro consome :" + res + " Litros por KM");
            Console.WriteLine();
        }
    }
}