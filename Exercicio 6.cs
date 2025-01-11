using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 1, 5, 6, 7, 8, 10, 11, 12, 16, 29 };
            int x = 16;
            
            Console.WriteLine($"Número próximo: {BuscaProximo(vet, x)}");

        }
        static int BuscaProximo(int[] vet, int x)
        {
            int esq = 0;
            int dir = vet.Length - 1;
            int meio;
            int valor = -1;
            while (esq <= dir)
            {
                meio = (esq + dir) / 2;

                if (x == vet[meio])
                {
                    if(esq < dir)
                    {
                        valor = vet[meio-1];
                        break;
                    }
                    else
                    {
                        if (esq == 0)
                        {
                            valor = vet[meio + 1];
                            break;
                        }
                        else
                        {
                            valor = vet[meio - 1];
                            break;
                        }
                    }
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
            return valor;
            
        }
    }
}
