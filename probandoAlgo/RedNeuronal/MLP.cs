using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoAlgo.RedNeuronal
{
    class MLP : RedNeuronal
    {
        private int cantidad_capas_ocultas;
        private List<float[][]> lista_de_matrices;
        private int tamano_salida;

        //metodo constructor
        // n_c = cantidad de neuronas en la capa c
        public MLP(int[] n_c)
        {
          
            cantidad_capas_ocultas = n_c.Count() - 2;

            Console.WriteLine("cantidad capas ocultas : "+cantidad_capas_ocultas);

            tamano_salida = n_c.ElementAt(n_c.Length-1);

            Console.WriteLine("tamaño de la salida "+tamano_salida);

            lista_de_matrices = new List<float[][]>();

            for (int i = 0; i <=cantidad_capas_ocultas; ++i)
            {
                Console.WriteLine("vuelta "+i+":");
                Console.WriteLine(n_c.ElementAt(i + 1));
                Console.WriteLine(n_c.ElementAt(i));
                lista_de_matrices.Add(Inicializar_matriz_bidimensional(n_c.ElementAt(i + 1), n_c.ElementAt(i)));
            }
            Console.WriteLine("cantidad de matrices en la lista: "+lista_de_matrices.Count);
            Print.inicializacionJaggedArray(lista_de_matrices);
        }

        public float[] FeedForward(float[] vector_de_entrada)
        {
            float[] vector_de_salida_red;

            float[] vector_de_activacion;

            //preactivacion y activacion de la primera capa oculta
            float[] salida_de_preactivacion = Preactivacion(lista_de_matrices[0], vector_de_entrada);

            vector_de_activacion = Activacion(salida_de_preactivacion,"tanh");

            if (lista_de_matrices.Count > 2)
            {
                //preactivacion y activacion de las capas intemedias
                for (int i = 1; i < lista_de_matrices.Count-1; ++i)
                {
                    salida_de_preactivacion = Preactivacion(lista_de_matrices[i], vector_de_activacion);

                    vector_de_activacion = Activacion(salida_de_preactivacion, "sigmoide");

                }
            }
            //preactivacion y activacion de la capa de salida
            salida_de_preactivacion = Preactivacion(lista_de_matrices[lista_de_matrices.Count], vector_de_activacion);

            vector_de_salida_red = Activacion(salida_de_preactivacion, "Relu");

            return vector_de_salida_red;
        }
    }
}
