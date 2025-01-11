using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int x = 15;
            Random rnd = new Random();
            int num = 0;
            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = num;
                num = num + rnd.Next(1,10);
                
            }
            int result = BuscaBinaria(vet,x);
            if (result == -1)
            {
                Console.WriteLine("Valor não encontrado.");
            }
            else
            {
                Console.WriteLine($"Valor encontrado na posição {result}.");
            }
        }
        static int BuscaBinaria(int[] vet, int x)
        {
            int esq = 0;
            int dir = vet.Length - 1;
            int meio;
            int resp = -1;
            while (esq <= dir)
            {
                meio = (esq + dir) / 2;

                if (x == vet[meio])
                {
                    return meio;
                }
                else if (x > vet[meio])
                {
                    esq = meio + 1;
                }
                else
                {
                    dir = meio - 1;

                }
            }
            return resp;
        }
    }
}
