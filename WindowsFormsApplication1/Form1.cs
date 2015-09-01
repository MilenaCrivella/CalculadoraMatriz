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

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
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

            Matriz = new TextBox[linha, coluna];

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Top = (i * Matriz[i, j].Height) + 100;
                    Matriz[i, j].Left = j * 35  + 380;
                    Matriz[i, j].Width = 30;
                    this.Controls.Add(Matriz[i, j]);
                }
            }
        }

    }
}
