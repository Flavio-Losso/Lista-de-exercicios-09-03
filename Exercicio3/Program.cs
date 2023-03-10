namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o raio");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe a altura");
            double a2 = Convert.ToDouble(Console.ReadLine());
            a1 = Math.Sqrt(a1);
            double res = Math.Round(Math.PI * a1 * a2, 3);
            Console.WriteLine("O volume é :"+res);
            Console.WriteLine();
        }
    }
}