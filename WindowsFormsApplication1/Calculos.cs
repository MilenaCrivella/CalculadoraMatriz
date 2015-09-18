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

        public float Determinante(float[,] Matriz1)
        {
            int num1;
            int num2;
            int Resp;
                if (Matriz1.GetLength(0) == 1)
                {
                    Console.WriteLine(Matriz1[0, 0]);
                }
                else if (Matriz1.GetLength(0) == 2)
                {
                    Console.WriteLine("2x2");
                    num1 = Convert.ToInt32(Matriz1[0, 0]) * Convert.ToInt32(Matriz1[1, 1]);
                    num2 = Convert.ToInt32(Matriz1[0, 1]) * Convert.ToInt32(Matriz1[1, 0]);
                    Resp = num1 - num2;
                }
                else if (Matriz1.GetLength(0) == 3)
                {
                    num1 = (Convert.ToInt32(Matriz1[0, 0]) * Convert.ToInt32(Matriz1[1, 1]) * Convert.ToInt32(Matriz1[2, 2])) +
                           (Convert.ToInt32(Matriz1[0, 1]) * Convert.ToInt32(Matriz1[1, 2]) * Convert.ToInt32(Matriz1[2, 0])) +
                           (Convert.ToInt32(Matriz1[0, 2]) * Convert.ToInt32(Matriz1[1, 0]) * Convert.ToInt32(Matriz1[2, 1]));

                    num2 = (Convert.ToInt32(Matriz1[0, 1]) * Convert.ToInt32(Matriz1[1, 0]) * Convert.ToInt32(Matriz1[2, 2])) +
                           (Convert.ToInt32(Matriz1[0, 0]) * Convert.ToInt32(Matriz1[1, 2]) * Convert.ToInt32(Matriz1[2, 1])) +
                           (Convert.ToInt32(Matriz1[0, 2]) * Convert.ToInt32(Matriz1[1, 1]) * Convert.ToInt32(Matriz1[2, 0]));

                    Resp = num1 - num2;

                }
                else
                {
                    for (int i = 1; i < Matriz1.GetLength(0); i++)
                    {
                        for (int j = 1; j < Matriz1.GetLength(1); j++)
                        {
                            Resp = Convert.ToInt32(Matriz1[i, j]) - Convert.ToInt32(Matriz1[0, j]) * Convert.ToInt32(Matriz1[i, 0]);
                            Console.WriteLine(Resp);
                        }
                    }

                }
            
        }

       
    } 
}
