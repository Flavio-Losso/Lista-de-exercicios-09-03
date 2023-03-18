using System.Reflection.PortableExecutable;

namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu peso");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe sua altura");
            double a = Convert.ToDouble(Console.ReadLine());

            double imc = Math.Round(p/(a*a),1);
            if(imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }else if(imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Você está com peso normal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Você está acima do peso");
            }
            else { Console.WriteLine("Você está obeso"); }
        }
    }
}