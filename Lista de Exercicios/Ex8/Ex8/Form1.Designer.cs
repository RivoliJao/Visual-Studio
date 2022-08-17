namespace Ex8
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
            this.labDolar = new System.Windows.Forms.Label();
            this.labTaxa = new System.Windows.Forms.Label();
            this.labReal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtCota = new System.Windows.Forms.TextBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.btnConversao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labDolar
            // 
            this.labDolar.AutoSize = true;
            this.labDolar.Location = new System.Drawing.Point(72, 113);
            this.labDolar.Name = "labDolar";
            this.labDolar.Size = new System.Drawing.Size(139, 13);
            this.labDolar.TabIndex = 0;
            this.labDolar.Text = "Quantidade de dolar (US$) :";
            // 
            // labTaxa
            // 
            this.labTaxa.AutoSize = true;
            this.labTaxa.Location = new System.Drawing.Point(117, 141);
            this.labTaxa.Name = "labTaxa";
            this.labTaxa.Size = new System.Drawing.Size(94, 13);
            this.labTaxa.TabIndex = 1;
            this.labTaxa.Text = "Cotação do dolar :";
            // 
            // labReal
            // 
            this.labReal.AutoSize = true;
            this.labReal.Location = new System.Drawing.Point(90, 196);
            this.labReal.Name = "labReal";
            this.labReal.Size = new System.Drawing.Size(121, 13);
            this.labReal.TabIndex = 2;
            this.labReal.Text = "Reais (R$) convertidos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Converção de real para dolar ";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(217, 112);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(75, 20);
            this.txtDolar.TabIndex = 5;
            // 
            // txtCota
            // 
            this.txtCota.Location = new System.Drawing.Point(217, 138);
            this.txtCota.Name = "txtCota";
            this.txtCota.Size = new System.Drawing.Size(75, 20);
            this.txtCota.TabIndex = 6;
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(217, 193);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(75, 20);
            this.txtReal.TabIndex = 7;
            // 
            // btnConversao
            // 
            this.btnConversao.Location = new System.Drawing.Point(217, 164);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(75, 23);
            this.btnConversao.TabIndex = 8;
            this.btnConversao.Text = "Converter";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConversao);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.txtCota);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labReal);
            this.Controls.Add(this.labTaxa);
            this.Controls.Add(this.labDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDolar;
        private System.Windows.Forms.Label labTaxa;
        private System.Windows.Forms.Label labReal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtCota;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Button btnConversao;
    }
}

