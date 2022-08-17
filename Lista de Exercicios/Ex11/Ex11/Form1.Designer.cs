namespace Ex11
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
            this.labvalor = new System.Windows.Forms.Label();
            this.labTaxa = new System.Windows.Forms.Label();
            this.labValorFinal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labEx11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labvalor
            // 
            this.labvalor.AutoSize = true;
            this.labvalor.Location = new System.Drawing.Point(58, 136);
            this.labvalor.Name = "labvalor";
            this.labvalor.Size = new System.Drawing.Size(141, 13);
            this.labvalor.TabIndex = 0;
            this.labvalor.Text = "Valor bruto do produto (R$) :";
            this.labvalor.Click += new System.EventHandler(this.label1_Click);
            // 
            // labTaxa
            // 
            this.labTaxa.AutoSize = true;
            this.labTaxa.Location = new System.Drawing.Point(61, 173);
            this.labTaxa.Name = "labTaxa";
            this.labTaxa.Size = new System.Drawing.Size(138, 13);
            this.labTaxa.TabIndex = 1;
            this.labTaxa.Text = "Percentagem de ganho (%):";
            // 
            // labValorFinal
            // 
            this.labValorFinal.AutoSize = true;
            this.labValorFinal.Location = new System.Drawing.Point(78, 235);
            this.labValorFinal.Name = "labValorFinal";
            this.labValorFinal.Size = new System.Drawing.Size(121, 13);
            this.labValorFinal.TabIndex = 2;
            this.labValorFinal.Text = "Valor pago pelo cliente :";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(205, 133);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(75, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(205, 170);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(75, 20);
            this.txtTaxa.TabIndex = 4;
            this.txtTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(205, 232);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(75, 20);
            this.txtValorFinal.TabIndex = 5;
            this.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(205, 203);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labEx11
            // 
            this.labEx11.AutoSize = true;
            this.labEx11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labEx11.Location = new System.Drawing.Point(81, 44);
            this.labEx11.Name = "labEx11";
            this.labEx11.Size = new System.Drawing.Size(178, 17);
            this.labEx11.TabIndex = 7;
            this.labEx11.Text = "Calcular o preço de venda.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labEx11);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.labValorFinal);
            this.Controls.Add(this.labTaxa);
            this.Controls.Add(this.labvalor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labvalor;
        private System.Windows.Forms.Label labTaxa;
        private System.Windows.Forms.Label labValorFinal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labEx11;
    }
}

