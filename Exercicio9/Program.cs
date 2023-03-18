namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe a nota 1");
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a nota 2");
                double a2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a nota 3");
                double a3 = Convert.ToDouble(Console.ReadLine());

                double res = Math.Round(3 / ((1 / a1) + (1 / a2) + (1 / a3)),2);
                Console.WriteLine("A media harmonia é: " + res);
                Console.WriteLine();
            }
        }
    }
}