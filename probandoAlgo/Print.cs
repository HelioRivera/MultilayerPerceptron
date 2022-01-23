using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoAlgo
{
    static class Print
    {
        /*El proposito de esta clase es imprimir una determinada matriz para su observacion por parte del 
         desarrollador.*/
        public static void inicializacionJaggedArray(List<float[][]> L)
        {
            Console.WriteLine("imprimiendo las matrices para ver que ñaca ñaca tienen");
            foreach(float[][] l in L)
            {
                Console.WriteLine("filas :" + l.Length);
                Console.WriteLine("columnas :" + l[0].Length);
                for (int i = 0; i < l.Length; ++i)
                {
                    for (int j = 0; j < l[i].Length; ++j)
                    {
                        Console.Write(l[i][j] + "-");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void matrizJagged(float[][][,] matriz, int filas, int col, int dim1, int dim2)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("matriz " + i + " , " + j);
                    for (int f = 0; f < dim1; f++)
                    {
                        for (int c = 0; c < dim2; c++)
                        {
                            Console.Write("- " + matriz[i][j][f, c]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("impresion completa.");
        }
    }
}
