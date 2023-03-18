namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[3];
            Console.WriteLine("Informe o primeiro valor");
            i[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            i[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor");
            i[2] = Convert.ToInt32(Console.ReadLine());

            int primeiro =0, segundo=0, terceiro=0;
            for(int a=0; a<3; a++)
            {
                if (primeiro == 0)
                {
                    primeiro = i[a];
                }else if (i[a] > primeiro)
                {
                    if(segundo == 0)
                    {
                        segundo = primeiro;
                        primeiro = i[a];
                    }
                    else
                    {
                        terceiro = segundo;
                        segundo = primeiro;
                        primeiro = i[a];
                    }
                }else if (i[a]< primeiro && i[a]> segundo)
                {
                    terceiro = segundo;
                }
                else
                {
                    terceiro = i[a];
                }
            }
            Console.WriteLine($"Primeiro {primeiro} Segundo {segundo} Terceiro {terceiro}");

        }
    }
}