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
            this.bttSoma = new System.Windows.Forms.Button();
            this.bttSubtrair = new System.Windows.Forms.Button();
            this.bttMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Matriz1
            // 
            this.Matriz1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Matriz1.AutoSize = true;
            this.Matriz1.Font = new System.Drawing.Font("Moire", 11F);
            this.Matriz1.Location = new System.Drawing.Point(114, 12);
            this.Matriz1.Name = "Matriz1";
            this.Matriz1.Size = new System.Drawing.Size(71, 18);
            this.Matriz1.TabIndex = 0;
            this.Matriz1.Text = "Matriz 1";
            this.Matriz1.Visible = false;
            // 
            // Matriz2
            // 
            this.Matriz2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Matriz2.AutoSize = true;
            this.Matriz2.Font = new System.Drawing.Font("Moire", 11F);
            this.Matriz2.Location = new System.Drawing.Point(515, 12);
            this.Matriz2.Name = "Matriz2";
            this.Matriz2.Size = new System.Drawing.Size(71, 18);
            this.Matriz2.TabIndex = 1;
            this.Matriz2.Text = "Matriz 2";
            this.Matriz2.Visible = false;
            // 
            // Linhas1
            // 
            this.Linhas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Linhas1.Location = new System.Drawing.Point(96, 37);
            this.Linhas1.Multiline = true;
            this.Linhas1.Name = "Linhas1";
            this.Linhas1.Size = new System.Drawing.Size(34, 25);
            this.Linhas1.TabIndex = 7;
            this.Linhas1.Visible = false;
            // 
            // Colunas1
            // 
            this.Colunas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Colunas1.Location = new System.Drawing.Point(159, 37);
            this.Colunas1.Multiline = true;
            this.Colunas1.Name = "Colunas1";
            this.Colunas1.Size = new System.Drawing.Size(34, 25);
            this.Colunas1.TabIndex = 9;
            this.Colunas1.Visible = false;
            // 
            // colunas2
            // 
            this.colunas2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colunas2.Location = new System.Drawing.Point(565, 37);
            this.colunas2.Multiline = true;
            this.colunas2.Name = "colunas2";
            this.colunas2.Size = new System.Drawing.Size(34, 25);
            this.colunas2.TabIndex = 11;
            this.colunas2.Visible = false;
            // 
            // linhas2
            // 
            this.linhas2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linhas2.Location = new System.Drawing.Point(501, 37);
            this.linhas2.Multiline = true;
            this.linhas2.Name = "linhas2";
            this.linhas2.Size = new System.Drawing.Size(34, 25);
            this.linhas2.TabIndex = 10;
            this.linhas2.Visible = false;
            // 
            // X1
            // 
            this.X1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1.Location = new System.Drawing.Point(136, 43);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(17, 15);
            this.X1.TabIndex = 12;
            this.X1.Text = "X";
            this.X1.Visible = false;
            // 
            // X2
            // 
            this.X2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.X2.AutoSize = true;
            this.X2.Font = new System.Drawing.Font("Moire", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2.Location = new System.Drawing.Point(542, 43);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(17, 15);
            this.X2.TabIndex = 13;
            this.X2.Text = "X";
            this.X2.Visible = false;
            // 
            // CriarMatriz
            // 
            this.CriarMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CriarMatriz.Font = new System.Drawing.Font("Moire", 8F);
            this.CriarMatriz.Location = new System.Drawing.Point(221, 37);
            this.CriarMatriz.Name = "CriarMatriz";
            this.CriarMatriz.Size = new System.Drawing.Size(48, 23);
            this.CriarMatriz.TabIndex = 14;
            this.CriarMatriz.Text = "Criar";
            this.CriarMatriz.UseVisualStyleBackColor = true;
            this.CriarMatriz.Visible = false;
            this.CriarMatriz.Click += new System.EventHandler(this.Criar_Matriz);
            // 
            // CriarMatriz2
            // 
            this.CriarMatriz2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CriarMatriz2.Font = new System.Drawing.Font("Moire", 8F);
            this.CriarMatriz2.Location = new System.Drawing.Point(628, 37);
            this.CriarMatriz2.Name = "CriarMatriz2";
            this.CriarMatriz2.Size = new System.Drawing.Size(48, 23);
            this.CriarMatriz2.TabIndex = 15;
            this.CriarMatriz2.Text = "Criar";
            this.CriarMatriz2.UseVisualStyleBackColor = true;
            this.CriarMatriz2.Visible = false;
            this.CriarMatriz2.Click += new System.EventHandler(this.Criar_Matriz2);
            // 
            // bttSoma
            // 
            this.bttSoma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttSoma.Font = new System.Drawing.Font("Moire", 11F);
            this.bttSoma.Location = new System.Drawing.Point(317, 37);
            this.bttSoma.Name = "bttSoma";
            this.bttSoma.Size = new System.Drawing.Size(37, 27);
            this.bttSoma.TabIndex = 16;
            this.bttSoma.Text = "+";
            this.bttSoma.UseVisualStyleBackColor = true;
            this.bttSoma.Click += new System.EventHandler(this.Somar);
            // 
            // bttSubtrair
            // 
            this.bttSubtrair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttSubtrair.Font = new System.Drawing.Font("Moire", 11F);
            this.bttSubtrair.Location = new System.Drawing.Point(360, 37);
            this.bttSubtrair.Name = "bttSubtrair";
            this.bttSubtrair.Size = new System.Drawing.Size(37, 27);
            this.bttSubtrair.TabIndex = 17;
            this.bttSubtrair.Text = "-";
            this.bttSubtrair.UseVisualStyleBackColor = true;
            this.bttSubtrair.Click += new System.EventHandler(this.Subtrair);
            // 
            // bttMult
            // 
            this.bttMult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttMult.Font = new System.Drawing.Font("Moire", 11F);
            this.bttMult.Location = new System.Drawing.Point(403, 37);
            this.bttMult.Name = "bttMult";
            this.bttMult.Size = new System.Drawing.Size(37, 27);
            this.bttMult.TabIndex = 18;
            this.bttMult.Text = "*";
            this.bttMult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttMult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 435);
            this.Controls.Add(this.bttMult);
            this.Controls.Add(this.bttSubtrair);
            this.Controls.Add(this.bttSoma);
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
        private System.Windows.Forms.Button bttSoma;
        private System.Windows.Forms.Button bttSubtrair;
        private System.Windows.Forms.Button bttMult;

    }
}

