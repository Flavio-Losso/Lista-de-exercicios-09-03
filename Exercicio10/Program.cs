namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota da prova 1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota da prova 2");
            double a2 = Convert.ToDouble(Console.ReadLine());

            double res = Math.Round((a1+a2)/2, 2);
            Console.WriteLine("A media ponderada é: " + res);
            Console.WriteLine();
        }
    }
}