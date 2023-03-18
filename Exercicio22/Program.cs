namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            int a2 = Convert.ToInt32(Console.ReadLine());

            if (a1 == a2)
            {
                int c = a2 + a1;
                Console.WriteLine(c);
            }
            else
            {
                int c = a2 * a1;
                Console.WriteLine(c);
            }
        }
    }
}