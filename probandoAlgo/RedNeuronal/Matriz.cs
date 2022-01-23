using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoAlgo.RedNeuronal
{
    public abstract class Matriz
    {
        private Random azar;

        private float[][] Crear_matriz_bidimensional(int rows, int cols)
        {
            float[][] resultado = new float[rows][];//
            for (int i = 0; i < rows; ++i)
                resultado[i] = new float[cols]; //  
            return resultado;
        }

        protected float[][] Inicializar_matriz_bidimensional(int rows, int cols)
        {
            azar = new Random(0);
            float[][] resultado = Crear_matriz_bidimensional(rows, cols);
            int k = 0;
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    resultado[i][j] = (float)azar.NextDouble();
                }
            }
            return resultado;
        }

        // filas: primera dimension de la matriz externa, col: segunda dimension de la matriz externa ,
        // dim 1 y dim2 : dimensiones de la matriz interna
        //retorna una matriz que contiene matriz o matrices dentro de ella.
        public float[][][,] CrearMatrizDeMatriz(int filas, int col, int dim1, int dim2)
        {
            float[][][,] matrizjagged = new float[filas][][,];

            Random r = new Random(0);

            for (int i = 0; i < filas; i++)
            {
                matrizjagged[i] = new float[col][,];

                for (int j = 0; j < col; j++)
                {
                    matrizjagged[i][j] = new float[dim1, dim2];

                    for (int f = 0; f < dim1; f++)
                    {
                        for (int c = 0; c < dim2; c++)
                        {
                            matrizjagged[i][j][f, c] = (float)r.NextDouble();
                        }
                    }
                }
            }
            return matrizjagged;
        }

        protected float[] MultiplicarMatrizPorVector(float[][] matriz, float[] vector)
        {
            float[] vectorFinal = new float[matriz.GetLength(0)];
            for (int fila = 0; fila < matriz.Length; fila++)
            {
                for (int col = 0; col < matriz[fila].Length; col++)
                {
                    vectorFinal[fila] += matriz[fila][col] * vector[col];
                }
            }
            return vectorFinal;
        }


    }
}
