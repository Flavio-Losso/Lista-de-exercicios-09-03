namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero para ser fatoriado");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{f}! = ");
            int tot=f;
            for(int i = (f-1); i > 0; i--)
            {
                tot *= i;
            }
            for (int i = f; i > 0; i--)
            {
                if(i == 1)
                {
                    Console.Write($" {i}");
                }
                else
                {
                    Console.Write($" {i} X");
                }

            }
            Console.Write($" = {tot}");
        }
    }
}