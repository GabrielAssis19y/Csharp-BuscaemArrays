using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int x = 2;
            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(10);
            }
            int result = Buscar(vet, x);
            Console.WriteLine($"Número de aparições do número {x}: {result}");
        }
        static int Buscar(int[] vet, int x)
        {
            int cont = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (x == vet[i])
                {
                    cont++;
                }
            }
            return cont;
        }
    }
}
