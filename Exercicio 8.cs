using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 1, 5, 6, 7, 8, 10, 11, 12, 16, 29 };

            Console.WriteLine("Insira o valor para adicionar: ");
            Console.Write("{");
            foreach (int valor in vet)
            {
                Console.Write($" {valor}");
            }
            Console.Write(" }");
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());
            vet = BuscaProximo(vet, x);
            Console.WriteLine("Vetor: ");
            Console.Write("{");
            foreach (int valor in vet)
            {
                Console.Write($" {valor}");
            }
            Console.Write(" }");
            Console.WriteLine();

        }
        static int[] BuscaProximo(int[] vet, int x)
        {
            int [] novovet = new int[vet.Length + 1];
            int esq = 0;
            int dir = vet.Length - 1;
            int meio;
            while (esq <= dir)
            {
                meio = (esq + dir) / 2;

                if (x == vet[meio])
                {
                    esq = meio + 1;
                    break;
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
            for (int i = 0,j = 0 ; i < novovet.Length; i++, j++)
            {
                novovet[i] = vet[j];
                if (i == esq)
                {
                    novovet[i] = x;
                    j--;
                }
                
            }
            return novovet;

        }

    }
}
