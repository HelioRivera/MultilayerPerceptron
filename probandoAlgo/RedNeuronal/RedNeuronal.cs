using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoAlgo.RedNeuronal
{
    abstract class RedNeuronal:Matriz
    {
        private Random azar;

        protected float[] Preactivacion(float[][]matriz, float[]vector)
        {
            float[] vector_a_retornar = MultiplicarMatrizPorVector(matriz, vector);

            return vector_a_retornar;
        }

       

        protected float[] Activacion(float[] vector, string nombre_funcion_activacion)
        {
            float[] vector_de_activacion;

            switch (nombre_funcion_activacion)
            {
                case "Sigmoide":
                    vector_de_activacion = Sigmoide(vector);
                return vector_de_activacion;

                case "Tanh":
                    vector_de_activacion = Tanh(vector);
                return vector_de_activacion;

            }

            return null;
        }


        protected void ConvertToArray(List<object>lista)
        {

        }

        private float[] Sigmoide(float[] vector)
        {
            return null;
        }

        private float[] Tanh(float[] vector)
        {
            return null;
        }

        //recorre un arreglo tridimensional y a cada valor le aplica la funcion sigmoide
        protected float[,,] Sigmoide(float[,,] matriz)
        {
            float[,,] v = new float[matriz.GetUpperBound(0) + 1, matriz.GetUpperBound(1) + 1, matriz.GetUpperBound(2) + 1];

            for (int i = 0; i < matriz.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matriz.GetUpperBound(1) + 1; j++)
                {
                    for (int z = 0; z < matriz.GetUpperBound(2) + 1; z++)
                    {
                        v[i,j,z] = (float)(1 / (1 + Math.Exp(-1*matriz[i,j,z])));
                    }

                }

            }
            return v;
        }

        protected float[] Relu(float[] x)
        {
            float[] relu = new float[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 0)
                {
                    relu[i] = x[i];
                }
                else
                {
                    relu[i] = 0;
                }
            }
            return relu;
        }
    }
}
