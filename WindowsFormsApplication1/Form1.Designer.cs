namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Matriz1 = new System.Windows.Forms.Label();
            this.Matriz2 = new System.Windows.Forms.Label();
            this.Linhas1 = new System.Windows.Forms.TextBox();
            this.Colunas1 = new System.Windows.Forms.TextBox();
            this.colunas2 = new System.Windows.Forms.TextBox();
            this.linhas2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.CriarMatriz = new System.Windows.Forms.Button();
            this.CriarMatriz2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Matriz1
            // 
            this.Matriz1.AutoSize = true;
            this.Matriz1.Font = new System.Drawing.Font("Moire", 11F);
            this.Matriz1.Location = new System.Drawing.Point(52, 9);
            this.Matriz1.Name = "Matriz1";
            this.Matriz1.Size = new System.Drawing.Size(71, 18);
            this.Matriz1.TabIndex = 0;
            this.Matriz1.Text = "Matriz 1";
            this.Matriz1.Visible = false;
            // 
            // Matriz2
            // 
            this.Matriz2.AutoSize = true;
            this.Matriz2.Font = new System.Drawing.Font("Moire", 11F);
            this.Matriz2.Location = new System.Drawing.Point(453, 9);
            this.Matriz2.Name = "Matriz2";
            this.Matriz2.Size = new System.Drawing.Size(71, 18);
            this.Matriz2.TabIndex = 1;
            this.Matriz2.Text = "Matriz 2";
            this.Matriz2.Visible = false;
            // 
            // Linhas1
            // 
            this.Linhas1.Location = new System.Drawing.Point(34, 34);
            this.Linhas1.Multiline = true;
            this.Linhas1.Name = "Linhas1";
            this.Linhas1.Size = new System.Drawing.Size(34, 25);
            this.Linhas1.TabIndex = 7;
            this.Linhas1.Visible = false;
            // 
            // Colunas1
            // 
            this.Colunas1.Location = new System.Drawing.Point(97, 34);
            this.Colunas1.Multiline = true;
            this.Colunas1.Name = "Colunas1";
            this.Colunas1.Size = new System.Drawing.Size(34, 25);
            this.Colunas1.TabIndex = 9;
            this.Colunas1.Visible = false;
            // 
            // colunas2
            // 
            this.colunas2.Location = new System.Drawing.Point(503, 34);
            this.colunas2.Multiline = true;
            this.colunas2.Name = "colunas2";
            this.colunas2.Size = new System.Drawing.Size(34, 25);
            this.colunas2.TabIndex = 11;
            this.colunas2.Visible = false;
            // 
            // linhas2
            // 
            this.linhas2.Location = new System.Drawing.Point(439, 34);
            this.linhas2.Multiline = true;
            this.linhas2.Name = "linhas2";
            this.linhas2.Size = new System.Drawing.Size(34, 25);
            this.linhas2.TabIndex = 10;
            this.linhas2.Visible = false;
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1.Location = new System.Drawing.Point(74, 40);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(17, 15);
            this.X1.TabIndex = 12;
            this.X1.Text = "X";
            this.X1.Visible = false;
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2.Location = new System.Drawing.Point(480, 40);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(17, 15);
            this.X2.TabIndex = 13;
            this.X2.Text = "X";
            this.X2.Visible = false;
            // 
            // CriarMatriz
            // 
            this.CriarMatriz.Location = new System.Drawing.Point(159, 34);
            this.CriarMatriz.Name = "CriarMatriz";
            this.CriarMatriz.Size = new System.Drawing.Size(48, 23);
            this.CriarMatriz.TabIndex = 14;
            this.CriarMatriz.Text = "Criar";
            this.CriarMatriz.UseVisualStyleBackColor = true;
            this.CriarMatriz.Click += new System.EventHandler(this.Criar_Matriz);
            // 
            // CriarMatriz2
            // 
            this.CriarMatriz2.Location = new System.Drawing.Point(566, 34);
            this.CriarMatriz2.Name = "CriarMatriz2";
            this.CriarMatriz2.Size = new System.Drawing.Size(48, 23);
            this.CriarMatriz2.TabIndex = 15;
            this.CriarMatriz2.Text = "Criar";
            this.CriarMatriz2.UseVisualStyleBackColor = true;
            this.CriarMatriz2.Click += new System.EventHandler(this.Criar_Matriz2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moire", 11F);
            this.label1.Location = new System.Drawing.Point(832, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriarMatriz2);
            this.Controls.Add(this.CriarMatriz);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.colunas2);
            this.Controls.Add(this.linhas2);
            this.Controls.Add(this.Colunas1);
            this.Controls.Add(this.Linhas1);
            this.Controls.Add(this.Matriz2);
            this.Controls.Add(this.Matriz1);
            this.Name = "Form1";
            this.Text = "Calculadora de Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Matriz1;
        private System.Windows.Forms.Label Matriz2;
        private System.Windows.Forms.TextBox Linhas1;
        private System.Windows.Forms.TextBox Colunas1;
        private System.Windows.Forms.TextBox colunas2;
        private System.Windows.Forms.TextBox linhas2;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.Button CriarMatriz;
        private System.Windows.Forms.Button CriarMatriz2;
        private System.Windows.Forms.Label label1;

    }
}

