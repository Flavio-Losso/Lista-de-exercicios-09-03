namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n< 500)
            {
                if(n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
                n += 2;
            }
        }
    }
}