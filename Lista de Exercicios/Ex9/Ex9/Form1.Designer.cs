namespace Ex9
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnFunção = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labValor
            // 
            this.labValor.AutoSize = true;
            this.labValor.Location = new System.Drawing.Point(96, 151);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(92, 13);
            this.labValor.TabIndex = 0;
            this.labValor.Text = "Valor depositado :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor final do mês :";
            // 
            // btnFunção
            // 
            this.btnFunção.Location = new System.Drawing.Point(195, 177);
            this.btnFunção.Name = "btnFunção";
            this.btnFunção.Size = new System.Drawing.Size(100, 23);
            this.btnFunção.TabIndex = 2;
            this.btnFunção.Text = "Calcular";
            this.btnFunção.UseVisualStyleBackColor = true;
            this.btnFunção.Click += new System.EventHandler(this.btnFunção_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(195, 151);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(195, 203);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rendimento ao mês";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnFunção);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFunção;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label1;
    }
}

