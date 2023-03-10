namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio da esfera");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double res = (4 * Math.PI * (Math.Pow(a1,3))) / 3;
            res = Math.Round(res, 2);
            Console.WriteLine("O volume é :" + res);
            Console.WriteLine();
        }
    }
}