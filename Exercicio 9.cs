using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linha;
            int[,] matriz = new int[3, 9] {
                {2, 3, 4, 6, 7, 8, 9, 10, 10 },
                {4,4,5,7,10,11,13,14,15 },
                {5,5,6,8,11,12,15,16,20 } };
            int result = BuscaMatriz(matriz, 11, 0, out linha);
            if (result != -1)
            {
                Console.WriteLine($"Número localizado na linha {linha} e coluna {result}");
            }
            else
            {
                Console.WriteLine("Número não encontrado.");
            }
        }
        static int BuscaMatriz(int[,] matriz, int x, int lin, out int linha)
        {
            int esq = 0;
            int dir = matriz.GetLength(1) - 1;
            int meio;
            int coluna;
            if (lin < matriz.GetLength(0))
            {
                while (esq <= dir)
                {
                    meio = (esq + dir) / 2;

                    if (x == matriz[lin,meio])
                    {
                        linha = lin;
                        coluna = meio;
                        return coluna;
                    }
                    else if (x > matriz[lin, meio])
                    {
                        esq = meio + 1;
                    }
                    else
                    {
                        dir = meio - 1;
                    }
                }
            }
            else
            {
                linha = -1;
                return -1;

            }
            return BuscaMatriz(matriz, x, lin +1, out linha);

        }
    }
}
