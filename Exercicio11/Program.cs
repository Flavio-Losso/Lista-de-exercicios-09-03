namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Boolean primo = false;
            Boolean rd = true;
            while (rd == true)
            {
                if (2 % a1 != 0)
                {
                    primo = true;
                }
                else
                {
                    primo = false;
                    rd = false;
                }
                if (3 % a1 != 0)
                {
                    primo = true;
                }
                else
                {
                    primo = false;
                    rd = false;
                }
                if (5 % a1 != 0)
                {
                    primo = true;
                }
                else
                {
                    primo = false;
                    rd = false;
                }
                rd = false;
            }
            if (primo == true) {
                Console.WriteLine("O numero é primo");
            }
            else { Console.WriteLine("O numero não é primo"); }
            
        }
    }
}