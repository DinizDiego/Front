namespace ProjetoSistemaFront
{
    partial class Cadastrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cadastro = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(151, 165);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(120, 20);
            this.nome.TabIndex = 3;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 14.25F);
            this.label2.Location = new System.Drawing.Point(47, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 14.25F);
            this.label3.Location = new System.Drawing.Point(47, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(151, 231);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(120, 20);
            this.cidade.TabIndex = 7;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 14.25F);
            this.label4.Location = new System.Drawing.Point(47, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(151, 271);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(120, 20);
            this.estado.TabIndex = 9;
            this.estado.TextChanged += new System.EventHandler(this.estado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 14.25F);
            this.label5.Location = new System.Drawing.Point(47, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastrar Pessoa";
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cadastro.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro.Location = new System.Drawing.Point(99, 343);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(158, 62);
            this.cadastro.TabIndex = 11;
            this.cadastro.Text = "Cadastrar";
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(3, 2);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 12;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(151, 130);
            this.codigo.Mask = "99999";
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(120, 20);
            this.codigo.TabIndex = 13;
            this.codigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigo_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(151, 199);
            this.telefone.Mask = "(99) 99999-9999";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(120, 20);
            this.telefone.TabIndex = 14;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.MaskedTextBox codigo;
        private System.Windows.Forms.MaskedTextBox telefone;
    }
}