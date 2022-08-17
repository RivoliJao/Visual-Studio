namespace Ex19
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
            this.btn = new System.Windows.Forms.Button();
            this.txtfeminino = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMasculino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(219, 207);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Verificar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtfeminino
            // 
            this.txtfeminino.Location = new System.Drawing.Point(219, 240);
            this.txtfeminino.Name = "txtfeminino";
            this.txtfeminino.Size = new System.Drawing.Size(75, 20);
            this.txtfeminino.TabIndex = 10;
            this.txtfeminino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(219, 140);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(75, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de Pessoas do sexo feminino :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(97, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Verificação do numero.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o nome :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sexo Masculino (M) ou Feminino (F) :";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(219, 171);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(75, 20);
            this.txtSexo.TabIndex = 9;
            this.txtSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero de Pessoas do sexo masculino :";
            // 
            // txtMasculino
            // 
            this.txtMasculino.Location = new System.Drawing.Point(219, 266);
            this.txtMasculino.Name = "txtMasculino";
            this.txtMasculino.Size = new System.Drawing.Size(75, 20);
            this.txtMasculino.TabIndex = 10;
            this.txtMasculino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtMasculino);
            this.Controls.Add(this.txtfeminino);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtfeminino;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMasculino;
    }
}

