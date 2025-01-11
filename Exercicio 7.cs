using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int x = 5;
            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(10);
            }
            int [] result = BuscarIndices(vet,x);
            Console.WriteLine("Indices do valor: ");
            Console.Write("{");
            foreach (int valor in result)
            {
                Console.Write($" {valor}");
             
                
            }
            Console.Write(" }");
            Console.WriteLine();
            
        }
        static int[] BuscarIndices(int[] vet, int x)
        {
            List<int> Indices = new List<int>();

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == x)
                {
                    Indices.Add(i);
                }
            }
            
            return Indices.ToArray();
        } 

    }
}
