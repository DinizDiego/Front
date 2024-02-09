namespace ProjetoSistemaFront
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrar = new System.Windows.Forms.Button();
            this.conusultar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.cadastrar.Location = new System.Drawing.Point(243, 219);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(164, 39);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // conusultar
            // 
            this.conusultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.conusultar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conusultar.ForeColor = System.Drawing.Color.DarkBlue;
            this.conusultar.Location = new System.Drawing.Point(243, 264);
            this.conusultar.Name = "conusultar";
            this.conusultar.Size = new System.Drawing.Size(164, 39);
            this.conusultar.TabIndex = 1;
            this.conusultar.Text = "Consultar";
            this.conusultar.UseVisualStyleBackColor = false;
            this.conusultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(243, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(243, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escolha uma das opções abaixo:";
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(638, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.conusultar);
            this.Controls.Add(this.cadastrar);
            this.Name = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadatrar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button conusultar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}

