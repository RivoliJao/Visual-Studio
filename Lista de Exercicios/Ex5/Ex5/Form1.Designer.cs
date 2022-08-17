namespace Ex5
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
            this.labEx5 = new System.Windows.Forms.Label();
            this.labNome = new System.Windows.Forms.Label();
            this.labNota1 = new System.Windows.Forms.Label();
            this.labNota2 = new System.Windows.Forms.Label();
            this.labNota3 = new System.Windows.Forms.Label();
            this.labMedia = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnMedia = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labEx5
            // 
            this.labEx5.AutoSize = true;
            this.labEx5.Location = new System.Drawing.Point(72, 51);
            this.labEx5.Name = "labEx5";
            this.labEx5.Size = new System.Drawing.Size(135, 13);
            this.labEx5.TabIndex = 0;
            this.labEx5.Text = "Media Escolar de um aluno";
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(53, 125);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(130, 13);
            this.labNome.TabIndex = 0;
            this.labNome.Text = "Informe o nome do aluno :";
            // 
            // labNota1
            // 
            this.labNota1.AutoSize = true;
            this.labNota1.Location = new System.Drawing.Point(99, 158);
            this.labNota1.Name = "labNota1";
            this.labNota1.Size = new System.Drawing.Size(84, 13);
            this.labNota1.TabIndex = 0;
            this.labNota1.Text = "Insira a 1º nota :";
            // 
            // labNota2
            // 
            this.labNota2.AutoSize = true;
            this.labNota2.Location = new System.Drawing.Point(99, 187);
            this.labNota2.Name = "labNota2";
            this.labNota2.Size = new System.Drawing.Size(84, 13);
            this.labNota2.TabIndex = 0;
            this.labNota2.Text = "Insira a 2º nota :";
            // 
            // labNota3
            // 
            this.labNota3.AutoSize = true;
            this.labNota3.Location = new System.Drawing.Point(99, 212);
            this.labNota3.Name = "labNota3";
            this.labNota3.Size = new System.Drawing.Size(84, 13);
            this.labNota3.TabIndex = 0;
            this.labNota3.Text = "Insira a 3º nota :";
            // 
            // labMedia
            // 
            this.labMedia.AutoSize = true;
            this.labMedia.Location = new System.Drawing.Point(72, 264);
            this.labMedia.Name = "labMedia";
            this.labMedia.Size = new System.Drawing.Size(111, 13);
            this.labMedia.TabIndex = 0;
            this.labMedia.Text = "Média Final do aluno :";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(189, 158);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(189, 184);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 1;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(189, 209);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 1;
            this.txtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(189, 261);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 1;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(189, 235);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(100, 23);
            this.btnMedia.TabIndex = 2;
            this.btnMedia.Text = "Calcular";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(189, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.labMedia);
            this.Controls.Add(this.labNota3);
            this.Controls.Add(this.labNota2);
            this.Controls.Add(this.labNota1);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.labEx5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEx5;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labNota1;
        private System.Windows.Forms.Label labNota2;
        private System.Windows.Forms.Label labNota3;
        private System.Windows.Forms.Label labMedia;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.TextBox txtNome;
    }
}

