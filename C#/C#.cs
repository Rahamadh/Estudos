using System;

namespace ClassePrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            int contador = 0;

            for (int i = 0; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }
                if (contador == 2)
            {
                Console.WriteLine("{0} é um número primo.", num);
            }
            else
            {
                Console.WriteLine("{0} não é um número primo.", num);
            }
           
        }
    }
}
