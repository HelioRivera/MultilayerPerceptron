using probandoAlgo.RedNeuronal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoAlgo
{
    class Program
    {
        

        static void Main(string[] args)

        {
            int[] neuronas_por_capa = new int[] {2,4,4,2};
            MLP percep = new MLP(neuronas_por_capa);
            float[] vector_entrada = new float[] {4,3};
            percep.FeedForward(vector_entrada);
            Console.WriteLine("listo");
            Console.ReadKey();

            /*float[][][,] v ;

            Matriz matriz = new Matriz();
            int x = 5;
            int y = 5;
            int xx = 2;
            int yy = 2;

            v = matriz.CrearMatrizJagged(x,y,xx,yy);
            matriz.imprimirmatrizJagged(v, x, y, xx, yy);
            Console.ReadKey();*/
             /*int dimension0 = v.GetUpperBound(0) + 1 ;
            int dimension1 = v.GetUpperBound(1) + 1;
            int dimension2 = v.GetUpperBound(2) + 1;

            Console.WriteLine("dim 0:"  + dimension0);
            Console.WriteLine("dim 1:" + dimension1);
            Console.WriteLine("dim 2:" + dimension2);*/
            /*//float[,,] v = new float[];
             int z_row = 3;
             int z_col = 4;
             //int z_prof = 2;
             float[,] z = new float[z_row, z_col];
             int[,,] array3d = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                        { { 7, 8, 9 }, { 10, 11, 12 } } };
             Console.WriteLine("hola mundo");
             Console.WriteLine("dimension de matriz : " + array3d.Rank);
             Console.WriteLine("Cantidad de elementos : "+array3d.Length);
             //int dimension0 = array3d.GetUpperBound(0) + 1 ;
             //int dimension1 = array3d.GetUpperBound(1) + 1;
             //int dimension2 = array3d.GetUpperBound(2) + 1;

             for (int i = 0; i < array3d.GetUpperBound(0) + 1; i++)
             {
                 for (int j = 0; j < array3d.GetUpperBound(1) + 1; j++)
                 {
                     for (int x = 0; x < array3d.GetUpperBound(2) + 1; x++)
                     {
                         Console.WriteLine(array3d[i,j,x]);
                     }
                 }

             }
             //Console.WriteLine("dim 0:"  + dimension0);
             //Console.WriteLine("dim 1:" + dimension1);
             //Console.WriteLine("dim 2:" + dimension2);
             Console.ReadKey();*/




        }
    }
}
