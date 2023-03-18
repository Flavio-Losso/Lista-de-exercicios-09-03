namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 1 numero");
            int a= Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("é par");
            }
            else
            {
                Console.WriteLine("É impar");
            }
        }
    }
}