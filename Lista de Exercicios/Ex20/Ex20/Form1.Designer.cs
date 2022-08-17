namespace Ex20
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labDesconto = new System.Windows.Forms.Label();
            this.labPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(240, 198);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtBruto
            // 
            this.txtBruto.Location = new System.Drawing.Point(240, 146);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(100, 20);
            this.txtBruto.TabIndex = 12;
            this.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Calculando o desconto de um automovel.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço com Desconto (R$) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor do Desconto (R$) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preço Bruto (R$) :";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(240, 172);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ano de fabricação do automovel :";
            // 
            // labDesconto
            // 
            this.labDesconto.AutoSize = true;
            this.labDesconto.Location = new System.Drawing.Point(240, 234);
            this.labDesconto.Name = "labDesconto";
            this.labDesconto.Size = new System.Drawing.Size(25, 13);
            this.labDesconto.TabIndex = 16;
            this.labDesconto.Text = "......";
            // 
            // labPreco
            // 
            this.labPreco.AutoSize = true;
            this.labPreco.Location = new System.Drawing.Point(240, 262);
            this.labPreco.Name = "labPreco";
            this.labPreco.Size = new System.Drawing.Size(25, 13);
            this.labPreco.TabIndex = 17;
            this.labPreco.Text = "......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labPreco);
            this.Controls.Add(this.labDesconto);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBruto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labDesconto;
        private System.Windows.Forms.Label labPreco;
    }
}

