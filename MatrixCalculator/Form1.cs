using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {

        private TextBox[,] Matriz;
        private TextBox[,] Matriz_2;
        private TextBox[,] Matriz_3;
        private TextBox[,] Matriz_4;
        private TextBox[,] Matriz_5;

        Calculos calculos = new Calculos();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrixBox1.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown1.Value);
            coluna = Convert.ToInt32(columnUpDown1.Value);

            Matriz = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35 + 15;
                    Matriz[i, j].Width = 30;
                    this.matrixBox1.Controls.Add(Matriz[i, j]);
                }
            }

            matrixBox2.Controls.Clear();

            linha = Convert.ToInt32(lineUpDown2.Value);
            coluna = Convert.ToInt32(columnUpDown2.Value);

            Matriz_2 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    Matriz_2[i, j] = new TextBox();
                    Matriz_2[i, j].Text = "0";
                    Matriz_2[i, j].Top = (i * Matriz_2[i, j].Height) + 100;
                    Matriz_2[i, j].Left = j * 35 + 15;
                    Matriz_2[i, j].Width = 30;
                    this.matrixBox2.Controls.Add(Matriz_2[i, j]);
                }
            }

            matrixBox3.Controls.Clear();
            
            linha = Convert.ToInt32(lineUpDown3.Value);
            coluna = Convert.ToInt32(columnUpDown3.Value);

            Matriz_3 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_3.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_3.GetLength(1); j++)
                {
                    Matriz_3[i, j] = new TextBox();
                    Matriz_3[i, j].Text = "0";
                    Matriz_3[i, j].Top = (i * Matriz_3[i, j].Height) + 100;
                    Matriz_3[i, j].Left = j * 35 + 15;
                    Matriz_3[i, j].Width = 30;
                    this.matrixBox3.Controls.Add(Matriz_3[i, j]);
                }
            }

            matrixBox4.Controls.Clear();

            linha = Convert.ToInt32(lineUpDown4.Value);
            coluna = Convert.ToInt32(columnUpDown4.Value);

            Matriz_4 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_4.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_4.GetLength(1); j++)
                {
                    Matriz_4[i, j] = new TextBox();
                    Matriz_4[i, j].Text = "0";
                    Matriz_4[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz_4[i, j].Left = j * 35 + 15;
                    Matriz_4[i, j].Width = 30;
                    this.matrixBox4.Controls.Add(Matriz_4[i, j]);
                }
            }

            matrixBox5.Controls.Clear();

            linha = Convert.ToInt32(lineUpDown5.Value);
            coluna = Convert.ToInt32(columnUpDown5.Value);

            Matriz_5 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_5.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_5.GetLength(1); j++)
                {
                    Matriz_5[i, j] = new TextBox();
                    Matriz_5[i, j].Text = "0";
                    Matriz_5[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz_5[i, j].Left = j * 35 + 15;
                    Matriz_5[i, j].Width = 30;
                    this.matrixBox5.Controls.Add(Matriz_5[i, j]);
                }
            }
        }

        #region Criação de Matrizes

        #region Criar Matriz
        private void crateMatrix(TextBox[,] matrix_x, GroupBox matrix_box, NumericUpDown lines, NumericUpDown columns) {

            matrix_box.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lines.Value);
            coluna = Convert.ToInt32(columns.Value);

            matrix_x = new TextBox[linha, coluna];

            for (int i = 0; i < matrix_x.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_x.GetLength(1); j++)
                {
                    matrix_x[i, j] = new TextBox();
                    matrix_x[i, j].Text = "0";
                    matrix_x[i, j].Top = (i * matrix_x[i, j].Height) + 100;
                    matrix_x[i, j].Left = j * 35 + 15;
                    matrix_x[i, j].Width = 30;
                    matrix_box.Controls.Add(matrix_x[i, j]);
                }
            }
        }
        #endregion

        #region Criar Matriz 1
        private void lineUpDown1_ValueChanged(object sender, EventArgs e)
        {
            matrixBox1.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown1.Value);
            coluna = Convert.ToInt32(columnUpDown1.Value);

            Matriz = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35 + 15;
                    Matriz[i, j].Width = 30;
                    this.matrixBox1.Controls.Add(Matriz[i, j]);
                }
            }
        }

        private void columnUpDown1_ValueChanged(object sender, EventArgs e)
        {
            matrixBox1.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown1.Value);
            coluna = Convert.ToInt32(columnUpDown1.Value);

            Matriz = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35 + 15;
                    Matriz[i, j].Width = 30;
                    this.matrixBox1.Controls.Add(Matriz[i, j]);
                }
            }
        }
        #endregion

        #region Criar Matriz 2
        private void lineUpDown2_ValueChanged(object sender, EventArgs e)
        {
            matrixBox2.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown2.Value);
            coluna = Convert.ToInt32(columnUpDown2.Value);

            Matriz_2 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    Matriz_2[i, j] = new TextBox();
                    Matriz_2[i, j].Text = "0";
                    Matriz_2[i, j].Top = (i * Matriz_2[i, j].Height) + 100;
                    Matriz_2[i, j].Left = j * 35 + 15;
                    Matriz_2[i, j].Width = 30;
                    this.matrixBox2.Controls.Add(Matriz_2[i, j]);
                }
            }
        }

        private void columnUpDown2_ValueChanged(object sender, EventArgs e)
        {
            matrixBox2.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown2.Value);
            coluna = Convert.ToInt32(columnUpDown2.Value);

            Matriz_2 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    Matriz_2[i, j] = new TextBox();
                    Matriz_2[i, j].Text = "0";
                    Matriz_2[i, j].Top = (i * Matriz_2[i, j].Height) + 100;
                    Matriz_2[i, j].Left = j * 35 + 15;
                    Matriz_2[i, j].Width = 30;
                    this.matrixBox2.Controls.Add(Matriz_2[i, j]);
                }
            }
        }
        #endregion

        #region Criar Matriz 3
        private void lineUpDown3_ValueChanged(object sender, EventArgs e)
        {
            matrixBox3.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown3.Value);
            coluna = Convert.ToInt32(columnUpDown3.Value);

            Matriz_3 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_3.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_3.GetLength(1); j++)
                {
                    Matriz_3[i, j] = new TextBox();
                    Matriz_3[i, j].Text = "0";
                    Matriz_3[i, j].Top = (i * Matriz_3[i, j].Height) + 100;
                    Matriz_3[i, j].Left = j * 35 + 15;
                    Matriz_3[i, j].Width = 30;
                    this.matrixBox3.Controls.Add(Matriz_3[i, j]);
                }
            }
        }

        private void columnUpDown3_ValueChanged(object sender, EventArgs e)
        {
            matrixBox3.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown3.Value);
            coluna = Convert.ToInt32(columnUpDown3.Value);

            Matriz_3 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_3.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_3.GetLength(1); j++)
                {
                    Matriz_3[i, j] = new TextBox();
                    Matriz_3[i, j].Text = "0";
                    Matriz_3[i, j].Top = (i * Matriz_3[i, j].Height) + 100;
                    Matriz_3[i, j].Left = j * 35 + 15;
                    Matriz_3[i, j].Width = 30;
                    this.matrixBox3.Controls.Add(Matriz_3[i, j]);
                }
            }
        }
        #endregion
        #endregion

        #region Criação de Matriz Rápida
        #region Criar Matriz 4

        private void columnUpDown4_ValueChanged(object sender, EventArgs e)
        {
            matrixBox4.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown4.Value);
            coluna = Convert.ToInt32(columnUpDown4.Value);

            Matriz_4 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_4.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_4.GetLength(1); j++)
                {
                    Matriz_4[i, j] = new TextBox();
                    Matriz_4[i, j].Text = "0";
                    Matriz_4[i, j].Top = (i * Matriz_4[i, j].Height) + 100;
                    Matriz_4[i, j].Left = j * 35 + 15;
                    Matriz_4[i, j].Width = 30;
                    this.matrixBox4.Controls.Add(Matriz_4[i, j]);
                }
            }
        }
        #endregion

        #region Criar Matriz 5

        private void columnUpDown5_ValueChanged(object sender, EventArgs e)
        {
            matrixBox5.Controls.Clear();

            int linha, coluna;
            linha = Convert.ToInt32(lineUpDown5.Value);
            coluna = Convert.ToInt32(columnUpDown5.Value);

            Matriz_5 = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz_5.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_5.GetLength(1); j++)
                {
                    Matriz_5[i, j] = new TextBox();
                    Matriz_5[i, j].Text = "0";
                    Matriz_5[i, j].Top = (i * Matriz_5[i, j].Height) + 100;
                    Matriz_5[i, j].Left = j * 35 + 15;
                    Matriz_5[i, j].Width = 30;
                    this.matrixBox5.Controls.Add(Matriz_5[i, j]);
                }
            }
        }
        #endregion
        #endregion

        #region Operações Básicas
        #region Soma
        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (Matriz.GetLength(0) == Matriz_2.GetLength(0) && Matriz.GetLength(1) == Matriz_2.GetLength(1))
            {
                float[,] valorMatriz1 = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
                float[,] valorMatriz2 = new float[Matriz_2.GetLength(0), Matriz_2.GetLength(1)];

                lineUpDown3.Value = Matriz.GetLength(0);
                columnUpDown3.Value = Matriz.GetLength(1);

                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        float k = 0;
                        if (float.TryParse(Matriz[i, j].Text, out k))
                        {
                            valorMatriz1[i, j] = float.Parse(Matriz[i, j].Text);
                        }
                    }
                }

                for (int i = 0; i < Matriz_2.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz_2.GetLength(1); j++)
                    {
                        float k = 0;
                        if (float.TryParse(Matriz_2[i, j].Text, out k))
                        {
                            valorMatriz2[i, j] = float.Parse(Matriz_2[i, j].Text);
                        }
                    }
                }

                float[,] answer = calculos.Soma(valorMatriz1, valorMatriz2);

                for (int i = 0; i < Matriz_3.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz_3.GetLength(1); j++)
                    {
                        Matriz_3[i, j].Text = "" + answer[i, j];
                    }
                }
            }
            else {
                MessageBox.Show("Para adicionar duas matrizes é preciso que elas tenham o mesmo número de linhas e de colunas!");
            }
        }
        #endregion

        #region Subtração
        private void buttonSub_Click(object sender, EventArgs e)
        {

            if (Matriz.GetLength(0) == Matriz_2.GetLength(0) && Matriz.GetLength(1) == Matriz_2.GetLength(1))
            {
                float[,] valorMatriz1 = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
                float[,] valorMatriz2 = new float[Matriz_2.GetLength(0), Matriz_2.GetLength(1)];

                lineUpDown3.Value = Matriz.GetLength(0);
                columnUpDown3.Value = Matriz.GetLength(1);

                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        float k = 0;
                        if (float.TryParse(Matriz[i, j].Text, out k))
                        {
                            valorMatriz1[i, j] = float.Parse(Matriz[i, j].Text);
                        }
                    }
                }

                for (int i = 0; i < Matriz_2.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz_2.GetLength(1); j++)
                    {
                        float k = 0;
                        if (float.TryParse(Matriz_2[i, j].Text, out k))
                        {
                            valorMatriz2[i, j] = float.Parse(Matriz_2[i, j].Text);
                        }
                    }
                }

                float[,] answer = calculos.Subtrai(valorMatriz1, valorMatriz2);

                for (int i = 0; i < Matriz_3.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz_3.GetLength(1); j++)
                    {
                        Matriz_3[i, j].Text = "" + answer[i, j];
                    }
                }
            }
            else {
                MessageBox.Show("Para subtrair duas matrizes é preciso que elas tenham o mesmo número de linhas e de colunas!");
            }
        }
        #endregion

        #region Multiplicação
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (Matriz.GetLength(1) == Matriz_2.GetLength(0))
            {
                float[,] valorMatriz1 = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
                float[,] valorMatriz2 = new float[Matriz_2.GetLength(0), Matriz_2.GetLength(1)];

                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        float k = 0;
                        if (float.TryParse(Matriz[i, j].Text, out k))
                        {
                            valorMatriz1[i, j] = float.Parse(Matriz[i, j].Text);
                        }
                    }
                }

                for (int i = 0; i < Matriz_2.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz_2.GetLength(1); j++)
                    {
                        float k = 0;
                        if (float.TryParse(Matriz_2[i, j].Text, out k))
                        {
                            valorMatriz2[i, j] = float.Parse(Matriz_2[i, j].Text);
                        }
                    }
                }

                float[,] answer = calculos.Multiplica(valorMatriz1, valorMatriz2);

                lineUpDown3.Value = answer.GetLength(0);
                columnUpDown3.Value = answer.GetLength(1);

                for (int i = 0; i < Matriz_3.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz_3.GetLength(1); j++)
                    {
                        Matriz_3[i, j].Text = "" + answer[i, j];
                    }
                }
            }
            else {
                MessageBox.Show("O número de colunas da 1ª matriz deve ser igual ao número de linhas da 2ª matriz.");
            }
        }
        #endregion
        #endregion

        private void buttonForm1_Click(object sender, EventArgs e, int id, int type)
        {

        }


        

        #region Outras Operações
        #region Determinantes

        private float checkDet(TextBox[,] Matriz_x) {
            float[,] tempMatriz = new float[Matriz_x.GetLength(0), Matriz_x.GetLength(1)];

            for (int i = 0; i < Matriz_x.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_x.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_x[i, j].Text, out k))
                    {
                        tempMatriz[i, j] = float.Parse(Matriz_x[i, j].Text);
                    }
                }
            }

            float answer = calculos.Determinante(tempMatriz);
            return answer;
        }

        private void buttonDet1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O determinante desta matriz é " + checkDet(Matriz));
        }

        private void buttonDet2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O determinante desta matriz é " + checkDet(Matriz_2));
        }

        private void buttonDet3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O determinante desta matriz é " + checkDet(Matriz_3));
        }
        #endregion

        #region Transposta
        private void checkTransp(TextBox[,] Matriz_x) {
            float[,] tempMatriz = new float[Matriz_x.GetLength(0), Matriz_x.GetLength(1)];

            for (int i = 0; i < Matriz_x.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_x.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_x[i, j].Text, out k))
                    {
                        tempMatriz[i, j] = float.Parse(Matriz_x[i, j].Text);
                    }
                }
            }

            float[,] answer = calculos.Transposta(tempMatriz);

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Matriz_x[i, j].Text = "" + answer[i, j];
                }
            }
        }

        private void buttonTransp1_Click(object sender, EventArgs e)
        {
            checkTransp(Matriz);
        }

        private void buttonTransp2_Click(object sender, EventArgs e)
        {
            checkTransp(Matriz_2);
        }

        private void buttonTransp3_Click(object sender, EventArgs e)
        {
            checkTransp(Matriz_3);
        }
        #endregion

        #region Inversa
        private void checkInv(TextBox[,] Matriz_x)
        {
            float[,] tempMatriz = new float[Matriz_x.GetLength(0), Matriz_x.GetLength(1)];

            for (int i = 0; i < Matriz_x.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_x.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_x[i, j].Text, out k))
                    {
                        tempMatriz[i, j] = float.Parse(Matriz_x[i, j].Text);
                    }
                }
            }

            float[,] answer = calculos.Inversa(tempMatriz);

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Matriz_x[i, j].Text = "" + answer[i, j];
                }
            }
        }

        private void buttonInv1_Click(object sender, EventArgs e)
        {
            checkInv(Matriz);
        }

        private void buttonInv2_Click(object sender, EventArgs e)
        {
            checkInv(Matriz_2);
        }

        private void buttonInv3_Click(object sender, EventArgs e)
        {
            checkInv(Matriz_3);
        }
        #endregion

        #region Oposta
        private void checkOpo(TextBox[,] Matriz_x)
        {
            float[,] tempMatriz = new float[Matriz_x.GetLength(0), Matriz_x.GetLength(1)];

            for (int i = 0; i < Matriz_x.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_x.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_x[i, j].Text, out k))
                    {
                        tempMatriz[i, j] = float.Parse(Matriz_x[i, j].Text);
                    }
                }
            }

            float[,] answer = calculos.Oposta(tempMatriz);

            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Matriz_x[i, j].Text = "" + answer[i, j];
                }
            }
        }

        private void buttonOpo1_Click(object sender, EventArgs e){
            checkOpo(Matriz);
        }

        private void buttonOpo2_Click(object sender, EventArgs e){
            checkOpo(Matriz_2);
        }

        private void buttonOpo3_Click(object sender, EventArgs e){
            checkOpo(Matriz_3);
        }

        #endregion

        #endregion

        #region Cálculos das Transformções
        #region Translação
        private void butTransSum_Click(object sender, EventArgs e)
        {
            float[,] tempMatrix = new float[Matriz_4.GetLength(0), Matriz_4.GetLength(1)];

            for (int i = 0; i < Matriz_4.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_4.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_4[i, j].Text, out k))
                    {
                        tempMatrix[i, j] = float.Parse(Matriz_4[i, j].Text);
                    }
                }
            }

            float[,] answer = calculos.Translacao(tempMatrix, float.Parse(transX.Text), float.Parse(transY.Text));

            lineUpDown5.Value = answer.GetLength(0);
            columnUpDown5.Value = answer.GetLength(1);

            for (int i = 0; i < Matriz_5.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_5.GetLength(1); j++)
                {
                    Matriz_5[i, j].Text = "" + answer[i, j];
                }
            }

        }
        #endregion

        #region Escala
        private void butEsc_Click(object sender, EventArgs e)
        {
            float[,] tempMatrix = new float[Matriz_4.GetLength(0), Matriz_4.GetLength(1)];

            for (int i = 0; i < Matriz_4.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_4.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_4[i, j].Text, out k))
                    {
                        tempMatrix[i, j] = float.Parse(Matriz_4[i, j].Text);
                    }
                }
            }

            float[,] answer = calculos.Escala(tempMatrix, float.Parse(escX.Text), float.Parse(escY.Text));

            lineUpDown5.Value = answer.GetLength(0);
            columnUpDown5.Value = answer.GetLength(1);

            for (int i = 0; i < Matriz_5.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_5.GetLength(1); j++)
                {
                    Matriz_5[i, j].Text = "" + answer[i, j];
                }
            }
        }
        #endregion

        #region Rotação
        private void btnRot_Click(object sender, EventArgs e)
        {
            float[,] tempMatrix = new float[Matriz_4.GetLength(0), Matriz_4.GetLength(1)];

            for (int i = 0; i < Matriz_4.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_4.GetLength(1); j++)
                {
                    float k = 0;
                    if (float.TryParse(Matriz_4[i, j].Text, out k))
                    {
                        tempMatrix[i, j] = float.Parse(Matriz_4[i, j].Text);
                    }
                }
            }

            float[,] answer = calculos.Rotacao(tempMatrix, float.Parse(textRot.Text));

            lineUpDown5.Value = answer.GetLength(0);
            columnUpDown5.Value = answer.GetLength(1);

            for (int i = 0; i < Matriz_5.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_5.GetLength(1); j++)
                {
                    Matriz_5[i, j].Text = "" + answer[i, j];
                }
            }

        }
        #endregion
        #endregion

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Point[] allPoints;
            Point[] allPoints2;

            Graphics g;
            Graphics g2;

            allPoints = new Point[Matriz_4.GetLength(1)];
            allPoints2 = new Point[Matriz_5.GetLength(1)];

            for (int j = 0; j < Matriz_4.GetLength(1); j++)
            {
                allPoints[j] = new Point((pictureBox1.Size.Width / 2 + Convert.ToInt32(float.Parse(Matriz_4[0, j].Text))), (pictureBox1.Size.Height / 2 + Convert.ToInt32(float.Parse(Matriz_4[1, j].Text))));
            }

            g = pictureBox1.CreateGraphics();
            g2 = pictureBox2.CreateGraphics();

            for (int i = 0; i <= (pictureBox1.Size.Height / 2) / 10; i++)
            {
                g.DrawLine(Pens.BlueViolet, new Point(0, (pictureBox1.Size.Height / 2) + i * 10), new Point(pictureBox1.Size.Width, (pictureBox1.Size.Height / 2) + i * 10));
                g.DrawLine(Pens.BlueViolet, new Point(0, (pictureBox1.Size.Height / 2) - i * 10), new Point(pictureBox1.Size.Width, (pictureBox1.Size.Height / 2) - i * 10));

                g2.DrawLine(Pens.BlueViolet, new Point(0, (pictureBox1.Size.Height / 2) + i * 10), new Point(pictureBox1.Size.Width, (pictureBox1.Size.Height / 2) + i * 10));
                g2.DrawLine(Pens.BlueViolet, new Point(0, (pictureBox1.Size.Height / 2) - i * 10), new Point(pictureBox1.Size.Width, (pictureBox1.Size.Height / 2) - i * 10));
            }

            g.DrawLine(Pens.Red, new Point(0, (pictureBox1.Size.Height/2)), new Point((pictureBox1.Size.Width), (pictureBox1.Size.Height / 2)));
            g2.DrawLine(Pens.Red, new Point(0, (pictureBox1.Size.Height/2)), new Point((pictureBox1.Size.Width), (pictureBox1.Size.Height / 2)));

            for (int i = 0; i <= (pictureBox1.Size.Width / 2) / 10; i++)
            {
                g.DrawLine(Pens.BlueViolet, new Point((pictureBox1.Size.Width / 2) + i * 10, 0), new Point((pictureBox1.Size.Width / 2) + i * 10, pictureBox1.Size.Height));
                g.DrawLine(Pens.BlueViolet, new Point((pictureBox1.Size.Width / 2) - i * 10, 0), new Point((pictureBox1.Size.Width / 2) - i * 10, pictureBox1.Size.Height));

                g2.DrawLine(Pens.BlueViolet, new Point((pictureBox1.Size.Width / 2) + i * 10, 0), new Point((pictureBox1.Size.Width / 2) + i * 10, pictureBox1.Size.Height));
                g2.DrawLine(Pens.BlueViolet, new Point((pictureBox1.Size.Width / 2) - i * 10, 0), new Point((pictureBox1.Size.Width / 2) - i * 10, pictureBox1.Size.Height));
            }

            g.DrawLine(Pens.Red, new Point((pictureBox1.Size.Width / 2), 0), new Point((pictureBox1.Size.Width / 2), (pictureBox1.Size.Height)));
            g2.DrawLine(Pens.Red, new Point((pictureBox1.Size.Width / 2), 0), new Point((pictureBox1.Size.Width / 2), (pictureBox1.Size.Height)));

            g.DrawPolygon(Pens.Black, allPoints);


            for (int j = 0; j < Matriz_5.GetLength(1); j++)
            {
                allPoints2[j] = new Point((pictureBox1.Size.Width / 2 + Convert.ToInt32(float.Parse(Matriz_5[0, j].Text))), (pictureBox1.Size.Height / 2 + Convert.ToInt32(float.Parse(Matriz_5[1, j].Text))));
            }

            g2.DrawPolygon(Pens.Black, allPoints2);
        }

        private void tabPage3_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        #region Criar Matrizes

        #region Matriz 1
        private void buttonForm1_Click(object sender, EventArgs e)
        {
            float[,] answer = calculos.createMatrix(int.Parse("" + lineUpDown1.Value), int.Parse("" + columnUpDown1.Value), formForml1.Text);

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j].Text = "" + answer[i, j];
                }
            }
        }
        #endregion

        #region Matriz 2
        private void buttonForm2_Click(object sender, EventArgs e)
        {
            float[,] answer = calculos.createMatrix(int.Parse("" + lineUpDown2.Value), int.Parse("" + columnUpDown2.Value), formForml1.Text);

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j].Text = "" + answer[i, j];
                }
            }
        }
        #endregion

        #region Matriz 3

        #endregion
        private void buttonForm3_Click(object sender, EventArgs e)
        {
            float[,] answer = calculos.createMatrix(int.Parse("" + lineUpDown3.Value), int.Parse("" + columnUpDown3.Value), formForml1.Text);

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j].Text = "" + answer[i, j];
                }
            }
        }
        #endregion




    }
}
