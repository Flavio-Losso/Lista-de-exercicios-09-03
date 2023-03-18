namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero de broas vendidas");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o numero de pãos vendidas");
            decimal p = Convert.ToDecimal(Console.ReadLine());

            decimal total = Math.Round((b*0.15m)+(p*1.50m),2);
            decimal poupanca = Math.Round(total * 0.10m,2);
            Console.WriteLine($"Ele fez um total de {total} e dever guardar {poupanca}");
        }
    }
}