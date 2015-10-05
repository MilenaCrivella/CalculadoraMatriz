using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MatrixCalculator
{
    class Calculos
    {
        public int rows;
        public int columns;
        public float[,] answer;

        #region Operações Básicas
        #region Soma
        public float[,] Soma(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResposta = new float[matriz1.GetLength(0), matriz1.GetLength(1)];
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
        public float[,] Subtrai(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResposta = new float[matriz1.GetLength(0), matriz1.GetLength(1)];
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
        public float[,] Multiplica(float[,] matriz1, float[,] matriz2)
        {
            float[,] matrizResposta = new float[matriz1.GetLength(0), matriz2.GetLength(1)];
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
        #endregion

        public float[,] MultiplicaçaoNormal(float[,] matriz1, float M)
        {
            float[,] matrizResposta = new float[matriz1.GetLength(0), matriz1.GetLength(1)];
            for (int i = 0; i < matrizResposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResposta.GetLength(1); j++)
                {
                    matrizResposta[i, j] = matriz1[i, j] * M;
                }
            }
            return matrizResposta;
        }

        #region Outras operações
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
                    if (Matriz1[j, 0] != 0)
                    {

                        if (j != 0)
                        {
                            a *= -1;
                            float[] temp = new float[Matriz1.GetLength(0)];
                            for (int i = 0; i < Matriz1.GetLength(0); i++)
                            {
                                temp[i] = Matriz1[j, i];
                                Matriz1[j, i] = Matriz1[0, i];
                                Matriz1[0, i] = temp[i];
                            }
                        }
                        j = Matriz1.GetLength(0);
                        foi = true;
                    }
                }
                if (foi)
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
                            M2[i - 1, j - 1] = (Matriz1[i, j]) - (Matriz1[0, j]) * (Matriz1[i, 0]);
                            Console.WriteLine(Resp);
                        }
                    }
                    Resp = Determinante(M2);
                }
                else
                    Resp = 0;
            }
            return Resp / a;
        }
        #endregion

        #region Transposta
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
        #endregion

        #region Cofator
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
        #endregion

        #region Adjunta
        public float[,] Adjunta(float[,] Matriz1)
        {
            float[,] resposta = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    resposta[i, j] = Cofator(Matriz1, i, j);
                }
            }

            return Transposta(resposta);
        }
        #endregion

        #region Inversa
        public float[,] Inversa(float[,] Matriz1)
        {
            float[,] MatrizI = MultiplicaçaoNormal(Adjunta(Matriz1), 1 / Determinante(Matriz1));
            return MatrizI;
        }
        #endregion

        #region Oposta
        public float[,] Oposta(float[,] Matriz1) {

            float[,] answer = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];

            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    Matriz1[i, j] *= -1;
                }
            }

            return Matriz1;
        }
        #endregion
        #endregion

        #region Transformacoes
        #region Translacao
        public float[,] Translacao(float[,] matrix_x1, float xValue, float yValue)
        {
            float[,] answer = new float[matrix_x1.GetLength(0), matrix_x1.GetLength(1)];

            for (int j = 0; j < matrix_x1.GetLength(1); j++)
            {
                answer[0, j] = matrix_x1[0, j] + xValue;
                answer[1, j] = matrix_x1[1, j] + yValue;
            }

            return answer;
        }
        #endregion

        #region Escala
        public float[,] Escala(float[,] matrix_x1, float xValue, float yValue)
        {
            float[,] matrix_id = new float[matrix_x1.GetLength(0), matrix_x1.GetLength(0)];

            matrix_id[0, 0] = xValue;
            matrix_id[0, 1] = 0;
            matrix_id[1, 0] = 0;
            matrix_id[1, 1] = yValue;

            float[,] answer = new float[matrix_x1.GetLength(0), matrix_x1.GetLength(1)];

            answer = Multiplica(matrix_id, matrix_x1);

            return answer;
        }
        #endregion

        #region Rotação
        public float[,] Rotacao(float[,] matrix_x1, float a) {
            float angle = Convert.ToSingle(a * Math.PI / 180);
            float[,] matrix_d = new float[2, 2];
            matrix_d[0, 0] = float.Parse("" + Math.Cos(angle));             matrix_d[0, 1] = -(float.Parse("" + Math.Sin(angle)));
            matrix_d[1, 0] = float.Parse("" + Math.Sin(angle));             matrix_d[1, 1] = float.Parse("" + Math.Cos(angle));

            float[,] answer = new float[matrix_x1.GetLength(0), matrix_x1.GetLength(1)];

            answer = Multiplica(matrix_d, matrix_x1);

            return answer;
        }
        #endregion
        #endregion

        public static float Eval(string expression)
        {
            DataTable t = new DataTable();
            t.Columns.Add("expression", typeof(string), expression);
            DataRow row = t.NewRow();
            t.Rows.Add(row);
            return float.Parse((string)row["expression"]);
        }


        public float[,] createMatrix(int row, int colum, string formula) {
            float[,] answer = new float[row, colum];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    string a = formula.Replace("i", (i + 1).ToString());
                    a = a.Replace("j", (j + 1).ToString());
                    answer[i, j] = Eval(a);
                }
            }
            return answer;
        }
    }
}
