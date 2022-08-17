namespace Ex4
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
            this.labEx4 = new System.Windows.Forms.Label();
            this.labNome = new System.Windows.Forms.Label();
            this.labSalarioFixo = new System.Windows.Forms.Label();
            this.labVendas = new System.Windows.Forms.Label();
            this.labSalarioFim = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFixo = new System.Windows.Forms.TextBox();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labEx4
            // 
            this.labEx4.AutoSize = true;
            this.labEx4.Location = new System.Drawing.Point(55, 41);
            this.labEx4.Name = "labEx4";
            this.labEx4.Size = new System.Drawing.Size(661, 13);
            this.labEx4.TabIndex = 0;
            this.labEx4.Text = "Algoritmo que leia o nome de um vendedor, o seu salário fixo e o total de vendas " +
    "efetuadas por ele no mês e mstra o salário no final do mês";
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(102, 134);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(153, 13);
            this.labNome.TabIndex = 0;
            this.labNome.Text = "Escreva o nome do vendedor :";
            // 
            // labSalarioFixo
            // 
            this.labSalarioFixo.AutoSize = true;
            this.labSalarioFixo.Location = new System.Drawing.Point(126, 162);
            this.labSalarioFixo.Name = "labSalarioFixo";
            this.labSalarioFixo.Size = new System.Drawing.Size(129, 13);
            this.labSalarioFixo.TabIndex = 0;
            this.labSalarioFixo.Text = "Informe o salário fixo :  R$";
            // 
            // labVendas
            // 
            this.labVendas.AutoSize = true;
            this.labVendas.Location = new System.Drawing.Point(119, 188);
            this.labVendas.Name = "labVendas";
            this.labVendas.Size = new System.Drawing.Size(136, 13);
            this.labVendas.TabIndex = 0;
            this.labVendas.Text = "Vendas efetuadas no mês :";
            // 
            // labSalarioFim
            // 
            this.labSalarioFim.AutoSize = true;
            this.labSalarioFim.Location = new System.Drawing.Point(87, 256);
            this.labSalarioFim.Name = "labSalarioFim";
            this.labSalarioFim.Size = new System.Drawing.Size(168, 13);
            this.labSalarioFim.TabIndex = 0;
            this.labSalarioFim.Text = "O salário no fim de mês sera  :  R$";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(261, 131);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFixo
            // 
            this.txtFixo.Location = new System.Drawing.Point(261, 159);
            this.txtFixo.Name = "txtFixo";
            this.txtFixo.Size = new System.Drawing.Size(100, 20);
            this.txtFixo.TabIndex = 1;
            this.txtFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVendas
            // 
            this.txtVendas.Location = new System.Drawing.Point(261, 185);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(100, 20);
            this.txtVendas.TabIndex = 1;
            this.txtVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(261, 253);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(100, 20);
            this.txtFim.TabIndex = 1;
            this.txtFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(261, 221);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.txtVendas);
            this.Controls.Add(this.txtFixo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labSalarioFim);
            this.Controls.Add(this.labVendas);
            this.Controls.Add(this.labSalarioFixo);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.labEx4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEx4;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labSalarioFixo;
        private System.Windows.Forms.Label labVendas;
        private System.Windows.Forms.Label labSalarioFim;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFixo;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.Button btnCalcular;
    }
}

