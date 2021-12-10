using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_burbuja_bidireccional
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Metodo de Cocktail Sort");
            Console.Write("Longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            int[] vector;
            vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("--Ingrese valor {0}: ", i + 1);
                vector[i] = Int32.Parse(Console.ReadLine());
            }
            CocktailSort(vector);
            Console.WriteLine("Vector ordenado en forma ascendente y descendente");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadKey();
        }
        private static void CocktailSort(int[] vector)
        {
            int tem;
            int contador =0;
            for (int derecha = 0; derecha < vector.Length; derecha++)
            {
                if (contador % 2 == 0)
                {
                    for (int izquierda = 0; izquierda < vector.Length - 1; izquierda++)
                    {
                        if (vector[izquierda] > vector[izquierda + 1])
                        {
                            tem = vector[izquierda+1];
                            vector[izquierda+1] = vector[izquierda];
                            vector[izquierda] = tem;
                        }
                    }
                    contador++;
                }
                else
                {
                    for (int izquierda = vector.Length - 1; izquierda > 0; izquierda--)
                    {
                        if (vector[izquierda] < vector[izquierda - 1])
                        {
                            tem = vector[izquierda-1];
                            vector[izquierda-1] = vector[izquierda];
                            vector[izquierda] = tem;
                        }
                    }
                    contador++;
                }
            }
        }
    }
}
