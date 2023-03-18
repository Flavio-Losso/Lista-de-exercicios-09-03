namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a sua idade");
            int i = (365*Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Você ja viveu {i} dias ");
        }
    }
}