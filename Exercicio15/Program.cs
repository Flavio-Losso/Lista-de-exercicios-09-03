﻿namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura");
            decimal c = Convert.ToDecimal(Console.ReadLine());
            decimal aux = ((c * 9) / 5) + 32;
            aux = Math.Round(aux, 1);
            Console.WriteLine(aux + " F°");
            Console.WriteLine();
        }
    }
}