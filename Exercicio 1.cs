using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int Buscar(int [] vet, int x)
        {
            int result = -1;

            for (int i = 0; i < vet.Length; i++)
            {
                if (x == vet[i])
                {
                    result = i;
                    return result;
                }
            }
            return result;
        }
    }
}
