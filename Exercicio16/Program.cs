namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Salario");
            decimal Sal = Convert.ToDecimal(Console.ReadLine());

            decimal Saltot = Math.Round(Sal+(Sal * 0.15m), 2);
            decimal Salfim = Math.Round(Saltot - (Saltot * 0.08m), 2);
            Console.WriteLine($"O salario inicial era de: {Sal} com o aumento foi para {Saltot} e o final é de {Salfim} Reais");
        }
    }
}