namespace Ex16
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnResuldado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculando a média ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome do aluno :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Situação :";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(134, 144);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(71, 20);
            this.txtn1.TabIndex = 6;
            this.txtn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(134, 170);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(71, 20);
            this.txtN2.TabIndex = 6;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(134, 195);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(71, 20);
            this.txtN3.TabIndex = 6;
            this.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(134, 249);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(71, 20);
            this.txtSituacao.TabIndex = 6;
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // btnResuldado
            // 
            this.btnResuldado.Location = new System.Drawing.Point(134, 222);
            this.btnResuldado.Name = "btnResuldado";
            this.btnResuldado.Size = new System.Drawing.Size(71, 23);
            this.btnResuldado.TabIndex = 8;
            this.btnResuldado.Text = "Concluir";
            this.btnResuldado.UseVisualStyleBackColor = true;
            this.btnResuldado.Click += new System.EventHandler(this.btnResuldado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResuldado);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnResuldado;
    }
}

