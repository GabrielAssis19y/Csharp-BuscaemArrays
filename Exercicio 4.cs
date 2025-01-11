using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 1, 2, 8, 8, 8, 8, 8, 9, 9, 10 };
            int x = 8;
            
            int result = BuscaBinaria(vet, x, out int prim, out int ult);
            if (result == -1)
            {
                Console.WriteLine("Valor não encontrado.");
            }
            else
            {
                if (ult != -1)
                {
                    Console.WriteLine($"Primeira ocorrência: posição {prim}.\nUltima ocorrência: posição {ult}.");
                }
                else
                {
                    Console.WriteLine($"Primeira ocorrência: posição {prim}.\n Não ocorreu outra ocorrência.");
                }
            }
        }

        static int BuscaBinaria(int[] vet, int x, out int prim, out int ult)
        {
            int esq = 0;
            int dir = vet.Length - 1;
            int meio;
            prim = -1;
            ult = -1;

            while (esq <= dir)
            {
                meio = (esq + dir) / 2;

                if (x == vet[meio])
                {
                    
                    if (prim == -1)
                    {
                        prim = meio;
                        for (int i = meio - 1; i >= esq; i--)
                        {
                            if (vet[i] == x)
                            {
                                prim = i;
                            }
                            else
                            {
                                break;
                            }
                        }
                        
                        esq = meio + 1;
                    }
                    else
                    {
                        ult = meio;
                        esq = meio + 1;
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

            
            return prim;
        }

    }
}