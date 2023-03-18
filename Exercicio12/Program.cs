namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Distancia do terreno");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Largura do terreno");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O terreno tem uma area de {b*a}m²");
            Console.WriteLine();
        }
    }
}