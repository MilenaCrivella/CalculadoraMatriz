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
    public partial class Form1 : Form
    {
        string promptValue = Calculo_Formula.ShowDialog("Calcular matriz:", "Determinando a matriz");
        private TextBox [,] Matriz;
        private TextBox [,] Matriz_2;
        Calculos calculos = new Calculos();
        int i;
        int j;


        //int[,] varMatriz1 = new int[Matriz.GetLength(0), Matriz.GetLength(1)];
        public Form1()
        {
            InitializeComponent();
            Calculo_Formula prompt = new Calculo_Formula();
            calc();
        }

        public void calc()
        {
            if (promptValue == "calc") 
            {
                Matriz1.Visible = true;
                Matriz2.Visible = true;
                Linhas1.Visible = true;
                linhas2.Visible = true;
                Colunas1.Visible = true;
                colunas2.Visible = true;
                X1.Visible = true;
                X2.Visible = true;
                CriarMatriz.Visible = true;
                CriarMatriz2.Visible = true;

            }

            if (promptValue == "form")
            {

            }
        }

        private void Criar_Matriz(object sender, EventArgs e)
        {

            int linha = Int16.Parse(Linhas1.Text);
            int coluna = Int16.Parse(Colunas1.Text);

            Matriz = new TextBox[linha, coluna];

            for (i = 0; i < Matriz.GetLength(0); i++)
            {
                for (j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35 + 15;
                    Matriz[i, j].Width = 30;
                    this.Controls.Add(Matriz[i, j]);
                }
            }
        }

        private void Criar_Matriz2(object sender, EventArgs e)
        {
            int linha = Int16.Parse(linhas2.Text);
            int coluna = Int16.Parse(colunas2.Text);

            Matriz_2 = new TextBox[linha, coluna];

            for (i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    Matriz_2[i, j] = new TextBox();
                    Matriz_2[i, j].Text = "0";
                    Matriz_2[i, j].Top = (i * Matriz_2[i, j].Height) + 100;
                    Matriz_2[i, j].Left = j * 35  + 380;
                    Matriz_2[i, j].Width = 30;
                    this.Controls.Add(Matriz_2[i, j]);
                }
            }
        }
        private void Somar(object sender, EventArgs e)
        {

            int[,] valorMatriz1 = new int[Matriz.GetLength(0), Matriz.GetLength(1)];
            int[,] valorMatriz2 = new int[Matriz_2.GetLength(0), Matriz_2.GetLength(1)];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    int k = 0;
                    int.TryParse(Matriz[i, j].Text, out k);
                    valorMatriz1[i, j] = k;
                }
            }

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    int k = 0;
                    int.TryParse(Matriz_2[i, j].Text, out k);
                    valorMatriz2[i, j] = k;
                }
            }


            
            if (Linhas1.Text == linhas2.Text && Colunas1.Text == colunas2.Text) 
            {
                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        int[,] resposta = calculos.Soma(valorMatriz1, valorMatriz2);
                        Console.WriteLine(resposta[i, j]);
                    }
                }
            }
        }

        private void Subtrair(object sender, EventArgs e)
        {
            int[,] valorMatriz1 = new int[Matriz.GetLength(0), Matriz.GetLength(1)];
            int[,] valorMatriz2 = new int[Matriz_2.GetLength(0), Matriz_2.GetLength(1)];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    int k = 0;
                    int.TryParse(Matriz[i, j].Text, out k);
                    valorMatriz1[i, j] = k;
                }
            }

            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    int k = 0;
                    int.TryParse(Matriz_2[i, j].Text, out k);
                    valorMatriz2[i, j] = k;
                }
            }



            if (Linhas1.Text == linhas2.Text && Colunas1.Text == colunas2.Text)
            {
                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        int[,] resposta = calculos.Subtrai(valorMatriz1, valorMatriz2);
                        Console.WriteLine(resposta[i, j]);
                    }
                }
            }
        }

    }
}
