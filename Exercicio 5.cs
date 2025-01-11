using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(10);
            }
            if (Ordenado(vet))
            {
                Console.WriteLine("O array está ordenado!.");
            }
            else
            {
                Console.WriteLine("O array não esta ordenado");
            }
            
        }
        static bool Ordenado (int[] vet)
        {
            bool ordenado = true;
            for (int i = 0 ; i  < vet.Length - 1; i++)
            {
                if( vet[i] > vet[i+1])
                {
                    ordenado = false;
                    break;
                }
            }
            return ordenado;
        }
    }
}
