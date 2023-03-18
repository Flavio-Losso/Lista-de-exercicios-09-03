using System;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean rpa = true;
            while (rpa == true){
                Console.WriteLine("Escreva 1 para lata cilindrica, 2 Para retangular ou 3 para sair");
                string auxs = Console.ReadLine();
                double res = 0;
                if (auxs != "1" && auxs != "2" && auxs != "3")
                {
                    Console.WriteLine("Valor invalido tente novamente");
                }
                else
                {
                    if (auxs == "1")
                    {
                        Console.WriteLine("informe o raio da lata");
                        double a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("informe a altura da lata");
                        double a2 = Convert.ToDouble(Console.ReadLine());
                        a1 = Math.Sqrt(a1);
                        res = Math.Round(Math.PI * a1 * a2, 3);
                    }
                    if (auxs == "2")
                    {
                        Console.WriteLine("informe a base da lata");
                        double aux1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a largura da lata");
                        double aux2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a altura da lata");
                        double aux3 = Convert.ToDouble(Console.ReadLine());

                        res = aux1 * aux2 * aux3;
                    }
                    if (auxs == "3")
                    {
                        rpa = false;
                        return;
                    }
                    Console.WriteLine("O volume da lata de óleo é :" + res);
                    Console.WriteLine();
                    rpa = true;
                }
            }
        }
    }
}