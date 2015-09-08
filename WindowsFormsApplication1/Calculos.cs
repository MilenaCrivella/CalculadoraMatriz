using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculos
    {
        public int [,] Soma (int [,] matriz1 ,int [,] matriz2)
        {
            int[,] matrizResposta = new int[matriz1.GetLength(0), matriz1.GetLength(1)];
            for (int i = 0; i < matrizResposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResposta.GetLength(1); j++)
                {
                    matrizResposta[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return matrizResposta;
        }

        public int[,] Subtrai (int[,] matriz1, int[,] matriz2)
        {
            int[,] matrizResposta = new int[matriz1.GetLength(0), matriz1.GetLength(1)];
            for (int i = 0; i < matrizResposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResposta.GetLength(1); j++)
                {
                    matrizResposta[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }
            return matrizResposta;
        }

        public int[,] Multiplica(int[,] matriz1, int[,] matriz2)
        {
            int[,] matrizResposta = new int[matriz1.GetLength(0), matriz2.GetLength(1)];
            for (int i = 0; i < matrizResposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResposta.GetLength(1); j++)
                {
                    for (int n = 0; n < matriz2.GetLength(0); n++)
                    {
                        string x = "" + matriz1[i, n];
                        matrizResposta[i, j] += matriz1[i, n] * matriz2[n, j];
                    }
                }
            }
            return matrizResposta;
        }
    } 
}
