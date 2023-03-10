namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salario Base");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o total de vendas");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o %");
            double a3 = Double.Parse(Console.ReadLine());
            double res = a1 + ((a3 / 100) * a2);
            res = Math.Round(res, 2);
            Console.WriteLine("Salario total: " + res);
            Console.WriteLine();
        }
    }
}