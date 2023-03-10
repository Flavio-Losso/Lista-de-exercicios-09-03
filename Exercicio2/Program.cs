namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura em Fahrenheit");
            decimal f = Convert.ToDecimal(Console.ReadLine());
            decimal aux = (f - 32) * 5 / 9;
            aux = Math.Round(aux, 1);
            Console.WriteLine(aux + " C°");
            Console.WriteLine();
        }
    }
}