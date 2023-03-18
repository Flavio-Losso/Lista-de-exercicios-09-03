namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor");
            int a3 = Convert.ToInt32(Console.ReadLine());

            if ((a1 + a2) > a3)
            {
                Console.WriteLine($"{a1} + {a2} é maior que {a3}");
            }
            else
            {
                Console.WriteLine($"{a1} + {a2} é menor que {a3}");
            }
        }
    }
}