namespace Ex10
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
            this.labValor = new System.Windows.Forms.Label();
            this.labPretacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtPrestacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labValor
            // 
            this.labValor.AutoSize = true;
            this.labValor.Location = new System.Drawing.Point(68, 110);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(114, 13);
            this.labValor.TabIndex = 0;
            this.labValor.Text = "Valor do produto (R$) :";
            // 
            // labPretacao
            // 
            this.labPretacao.AutoSize = true;
            this.labPretacao.Location = new System.Drawing.Point(30, 166);
            this.labPretacao.Name = "labPretacao";
            this.labPretacao.Size = new System.Drawing.Size(152, 13);
            this.labPretacao.TabIndex = 1;
            this.labPretacao.Text = "Valor de cada prestação (R$) :";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(188, 132);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(73, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(188, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(73, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrestacao
            // 
            this.txtPrestacao.Location = new System.Drawing.Point(188, 163);
            this.txtPrestacao.Name = "txtPrestacao";
            this.txtPrestacao.Size = new System.Drawing.Size(73, 20);
            this.txtPrestacao.TabIndex = 4;
            this.txtPrestacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calcular o preço de cada prestação.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrestacao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labPretacao);
            this.Controls.Add(this.labValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labValor;
        private System.Windows.Forms.Label labPretacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtPrestacao;
        private System.Windows.Forms.Label label1;
    }
}

