namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a base");
            double aux1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura");
            double aux2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura");
            double aux3 = Convert.ToDouble(Console.ReadLine());

            aux1 = aux1 * aux2 * aux3;

            Console.WriteLine(aux1);
            Console.WriteLine();
        }
    }
}