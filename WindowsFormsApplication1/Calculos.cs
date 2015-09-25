using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Calculos
    {
        
        #region Soma
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
        #endregion 

        #region Subtração
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
        #endregion 

        #region Multiplicação
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
        #endregion

        #region Determinante
        public float Determinante(float[,] Matriz1)
        {
            float num1;
            float num2;
            float Resp = 0;
            float a = 1;
                if (Matriz1.GetLength(0) == 1)
                {
                    return Matriz1[0, 0];
                }
                else if (Matriz1.GetLength(0) == 2)
                {
                    Console.WriteLine("2x2");
                    num1 = (Matriz1[0, 0]) * (Matriz1[1, 1]);
                    num2 = (Matriz1[0, 1]) * (Matriz1[1, 0]);
                    Resp = num1 - num2;
                }
                else if (Matriz1.GetLength(0) == 3)
                {
                    num1 = ((Matriz1[0, 0]) * (Matriz1[1, 1]) * (Matriz1[2, 2])) +
                           ((Matriz1[0, 1]) * (Matriz1[1, 2]) * (Matriz1[2, 0])) +
                           ((Matriz1[0, 2]) * (Matriz1[1, 0]) * (Matriz1[2, 1]));

                    num2 = ((Matriz1[0, 1]) * (Matriz1[1, 0]) * (Matriz1[2, 2])) +
                           ((Matriz1[0, 0]) * (Matriz1[1, 2]) * (Matriz1[2, 1])) +
                           ((Matriz1[0, 2]) * (Matriz1[1, 1]) * (Matriz1[2, 0]));

                    Resp = num1 - num2;

                }
                else
                {
                    bool foi = false;
                    for (int j = 0; j < Matriz1.GetLength(0); j++)
                    {
                        if(Matriz1[j,0] != 0)
                        {
                        
                            if(j != 0)
                            {
                                a *= -1;
                                float[] temp = new float[Matriz1.GetLength(0)];
                                for(int i = 0; i < Matriz1.GetLength(0); i++)
                                {
                                    temp[i] = Matriz1[j, i];
                                    Matriz1[j,i] = Matriz1[0,i];
                                    Matriz1[0, i] = temp[i];
                                }
                            }
                            j = Matriz1.GetLength(0);
                            foi = true;
                        }
                    }
                    if(foi)
                    {
                        a /= (Matriz1[0, 0]);
                        float[,] M2 = new float[Matriz1.GetLength(0) - 1, Matriz1.GetLength(1) - 1];
                        for (int i = 0; i < Matriz1.GetLength(0); i++)
                        {
                            Matriz1[i, 0] *= a;
                        }
                        for (int i = 1; i < Matriz1.GetLength(0); i++)
                        {
                            for (int j = 1; j < Matriz1.GetLength(1); j++)
                            {
                                M2[i-1,j-1] = (Matriz1[i, j]) - (Matriz1[0, j]) * (Matriz1[i, 0]);
                                Console.WriteLine(Resp);
                            }
                        }
                        Resp = Determinante(M2);
                    }
                    else
                        Resp = 0;
             }
                return Resp/a;
        }

        #endregion
        public float[,] Transposta(float[,] Matriz1)
        {
            float[,] a = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    a[i, j] = Matriz1[j, i];
                }
            }

            return a;
        }
        public float Cofator(float[,] Matriz1, int linha, int coluna)
        { 
            float[,] M2 = new float[Matriz1.GetLength(0) - 1, Matriz1.GetLength(1) - 1];
            int i2 = 0;
            int j2 = 0;
            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                if (i == linha) i++;
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    if (j == coluna) j++;
                    if (i < Matriz1.GetLength(0) && j < Matriz1.GetLength(1)) M2[i2, j2] = Matriz1[i, j];
                    j2++;
                }
                i2++;
                j2 = 0;
            }
            
                return (float)Math.Pow(-1, linha + coluna + 2) * Determinante(M2);
        }

        public float[,] Adjunta(float[,] Matriz1) 
        {
            float [,] resposta = new float [Matriz1.GetLength(0), Matriz1.GetLength(1)];
            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    resposta[i, j] = Cofator(Matriz1, i, j);
                }
            }

            return Transposta(resposta);
        }
        public float Inversa(float[,] Matriz1)
        {
            float Potencia =  0;
            float D = Determinante(Matriz1);  

            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                   Potencia = (float)Math.Pow(-1, (i+j));
                }
            }


            return Potencia;
        }
    } 
        
}
